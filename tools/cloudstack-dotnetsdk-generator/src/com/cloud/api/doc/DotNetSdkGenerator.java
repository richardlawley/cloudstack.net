package com.cloud.api.doc;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.util.HashMap;
import java.util.HashSet;
import java.util.List;
import java.util.Map;
import java.lang.reflect.Type;

import org.apache.cloudstack.api.ApiConstants;
import org.apache.log4j.Logger;

public class DotNetSdkGenerator extends ApiCommandProcessor {
    private static final Logger s_logger = Logger.getLogger(DotNetSdkGenerator.class.getName());
    private HashSet<String> _createdTypes = new HashSet<String>();

    public static void main(String[] args) {
        new ApiCommandProcessorProgram(new DotNetSdkGenerator()).Run(args);
    }

    public DotNetSdkGenerator() {
        excludeClassGeneration("AsyncJobResponse"); // Cannot be auto-generated due to dynamic JobResult field
    }

    public void excludeClassGeneration(String className) {
        _createdTypes.add(className);
    }

    @Override
    protected void WriteResultsCore(String baseDirectory, Map<String, Command> commands, List<String> allCommandNames, List<String> domainAdminCommandNames,
            List<String> userCommandNames) throws IOException {

        // Delete existing content
        File outputDir = new File(baseDirectory);
        for (File f : outputDir.listFiles()) {
            f.delete();
        }

        String namespace = "CloudStack.Net";
        String interfaceName = "ICloudStackAPIClient";
        String implementationName = "CloudStackAPIClient";
        String requestBase = "APIRequest";
        String requestListBase = "APIListRequest";
        String[] standardImports = { "System.Collections.Generic", "System.Collections.Specialized", "System.Threading.Tasks", "Newtonsoft.Json" };

        try {

            HashSet<String> writtenCommands = new HashSet<String>();
            Map<String, List<Argument>> typesToWrite = new HashMap<String, List<Argument>>();
            Map<String, Class<?>> enumsToWrite = new HashMap<String, Class<?>>();

            for (String commandName : allCommandNames) {
                if (writtenCommands.contains(commandName)) {
                    s_logger.warn(String.format("Command %s has already been processed", commandName));
                    continue;
                }
                writtenCommands.add(commandName);

                Command command = commands.get(commandName);
                if (command == null) {
                    s_logger.warn(String.format("Class for %s not found", commandName));
                } else {

                    String returnType = command.getResponseType();
                    returnType = returnType.substring(returnType.lastIndexOf('.') + 1);
                    String actualReturnType = returnType;

                    // Actual Command Name has an Upper Case initial to
                    // match .NET convention
                    String actualCommandName = commandName.substring(0, 1).toUpperCase() + commandName.substring(1);
                    String requestTypeName = actualCommandName + "Request";

                    // Create a file for this command's classes
                    try (DotNetFileWriter implementation = new DotNetFileWriter(new File(baseDirectory, actualCommandName + ".cs"), namespace, standardImports)) {

                        String requestBaseType = command.isList() ? requestListBase : requestBase;
                        
                        // Request Class
                        implementation.addType(requestTypeName + " : " + requestBaseType);
                        implementation.println("public %s() : base(\"%s\") {}", requestTypeName, command.getName());
                        implementation.println();

                        for (Argument arg : command.getRequest()) {
                            
                            if (!command.isList() || !(arg.getName().equalsIgnoreCase("page") || arg.getName().equalsIgnoreCase("pagesize"))) {
                                String convertedDataType = convertDataType(arg);
                                String convertedName = arg.getName();
                                convertedName = convertedName.substring(0, 1).toUpperCase() + convertedName.substring(1);
    
                                if (arg.getDescription() != null) {
                                    implementation.println("/// <summary>");
                                    implementation.println("/// " + arg.getDescription().replace("\n", "\n        /// "));
                                    implementation.println("/// </summary>");
                                }
    
                                String propertyName = arg.getNameWithCaps();
                                implementation.println("public %s %s {", convertedDataType, propertyName);
                                implementation.incrementIndent();
                                if (convertedDataType.startsWith("IList<")) {
                                    implementation.println("get { return GetList<%3$s>(nameof(%2$s).ToLower()); }", convertedDataType, propertyName,
                                            convertedDataType.substring("IList<".length(), convertedDataType.length() - 1));
                                } else {
                                    implementation.println("get { return (%s) Parameters[nameof(%s).ToLower()]; }", convertedDataType, propertyName);
                                }
                                implementation.println("set { Parameters[nameof(%s).ToLower()] = value; }", propertyName);
                                implementation.decrementIndent();
                                implementation.println("}");
    
                                // implementation.println("public %s %s { get; set; }", convertedDataType, arg.getNameWithCaps());
                                implementation.println();
                            }
                        }
                        implementation.closeTypeDef();

                        typesToWrite.put(returnType, command.getResponse());
                        if (command.isAsync()) {
                            actualReturnType = "AsyncJobResponse";
                        } else if (command.isList()) {
                            actualReturnType = String.format("ListResponse<%s>", returnType);
                            // String listContainerName = command.getListContainerName();
                            // if (listContainerName == null || listContainerName.isEmpty()) {
                            // listContainerName = getFallbackListName(commandName);
                            // }
                            //
                            // actualReturnType = actualCommandName + "Response";
                            // implementation.addType(actualReturnType);
                            // implementation.println("public int Count { get; set; }");
                            // implementation.println();
                            // implementation.println("[JsonProperty(\"%s\")]", listContainerName.toLowerCase());
                            // implementation.println("public IList<%s> %s { get; set; }", returnType, listContainerName + "s");
                            // implementation.println("public override string ToString() => JsonConvert.SerializeObject(this,
                            // Formatting.Indented);");
                            // implementation.closeTypeDef();
                        }

                        if (command.getDescription() != null) {
                            implementation.println("/// <summary>");
                            implementation.println("/// %s", command.getDescription().replace("\n", "\n /// "));
                            implementation.println("/// </summary>");
                        }
                        implementation.addType(interfaceName, "partial interface");
                        implementation.println("%1$s %2$s(%3$s request);", actualReturnType, actualCommandName, requestTypeName);
                        implementation.println("Task<%1$s> %2$sAsync(%3$s request);", actualReturnType, actualCommandName, requestTypeName);
                        if (command.isList()) {
                            implementation.println("%1$s %2$sAllPages(%3$s request);", actualReturnType, actualCommandName, requestTypeName);
                            implementation.println("Task<%1$s> %2$sAllPagesAsync(%3$s request);", actualReturnType, actualCommandName, requestTypeName);
                        }
                        implementation.closeTypeDef();

                        implementation.addType(implementationName + " : " + interfaceName, "partial class");
                        implementation.println("public %1$s %2$s(%3$s request) => _proxy.Request<%1$s>(request);", actualReturnType, actualCommandName, requestTypeName);
                        implementation.println("public Task<%1$s> %2$sAsync(%3$s request) => _proxy.RequestAsync<%1$s>(request);", actualReturnType, actualCommandName, requestTypeName);
                        if (command.isList()) {
                            implementation.println("public %1$s %2$sAllPages(%3$s request) => _proxy.RequestAllPages<%4$s>(request);", actualReturnType, actualCommandName, requestTypeName, returnType);
                            implementation.println("public Task<%1$s> %2$sAllPagesAsync(%3$s request) => _proxy.RequestAllPagesAsync<%4$s>(request);", actualReturnType, actualCommandName, requestTypeName, returnType);
                        }
                        implementation.closeTypeDef();
                    }
                }
            }

            // We need to write any classes which were referenced but haven't
            // already been created
            while (!typesToWrite.isEmpty()) {
                String typeName = typesToWrite.keySet().iterator().next();
                List<Argument> responseArgs = typesToWrite.get(typeName);

                // Handle response class
                if (!_createdTypes.contains(typeName)) {

                    try (DotNetFileWriter typeDefinition = new DotNetFileWriter(baseDirectory, namespace, standardImports, typeName)) {
                        HashSet<String> seenArgs = new HashSet<String>();
                        for (Argument arg : responseArgs) {
                            if (seenArgs.contains(arg.getNameWithCaps())) {
                                s_logger.warn(String.format("%s.%s - Duplicate Property Skipped", typeName, arg.getNameWithCaps()));
                                continue;
                            }
                            seenArgs.add(arg.getNameWithCaps());

                            String convertedDataType = convertDataType(arg);

                            if (arg.getDescription() != null) {
                                typeDefinition.println("/// <summary>");
                                typeDefinition.println("/// " + arg.getDescription().replace("\n", "\n        /// "));
                                typeDefinition.println("/// </summary>");
                            }

                            if (arg.getJavaDataTypeName() != null && !arg.getJavaDataType().getName().startsWith("java.") && !_createdTypes.contains(arg.getJavaDataTypeName())) {
                                if (arg.getJavaDataType().isEnum()) {
                                    String enumName = getEnumName(arg.getJavaDataType());
                                    enumsToWrite.put(enumName, arg.getJavaDataType());
                                    convertedDataType = enumName;
                                } else {
                                    List<Argument> nestedArgs = arg.getArguments();
                                    if (nestedArgs != null) {
                                        typesToWrite.put(arg.getJavaDataTypeName(), arg.getArguments());
                                    } else {
                                        s_logger.warn("Complex data type not referenced properly: " + arg.getName() + "(" + arg.getJavaDataTypeName() + ")");
                                    }
                                }
                            }
                            
                            typeDefinition.println("public %s %s { get; set; }", convertedDataType, arg.getNameWithCaps());
                            typeDefinition.println();
                        }

                        typeDefinition.println("public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);");
                        _createdTypes.add(typeName);
                    }
                }

                typesToWrite.remove(typeName);
            }

            while (!enumsToWrite.isEmpty()) {
                String enumName = enumsToWrite.keySet().iterator().next();
                Class<?> enumClass = enumsToWrite.get(enumName);

                if (!_createdTypes.contains(enumName)) {

                    try (DotNetFileWriter enumDefinition = new DotNetFileWriter(baseDirectory, namespace, new String[0], enumName, "enum")) {
                        for (Object member : enumClass.getEnumConstants()) {
                            enumDefinition.println("%s,", member.toString());
                        }
                    }

                    _createdTypes.add(enumName);
                }

                enumsToWrite.remove(enumName);
            }

            s_logger.info("DotNet SDK Generation Complete");

        } catch (FileNotFoundException e) {
            // TODO Auto-generated catch block
            e.printStackTrace();
        } catch (Exception e) {
            // TODO Auto-generated catch block
            e.printStackTrace();
        }
    }
    
    private String getEnumName(Class<?> enumClass) {
        String enumName = enumClass.getSimpleName();
        if (enumClass.getEnclosingClass() != null && !enumName.startsWith(enumClass.getEnclosingClass().getSimpleName())) {
            enumName = enumClass.getEnclosingClass().getSimpleName() + enumName;
        }
        return enumName;
    }

    private String convertDataType(Argument field) {
        if (field.getDataType() == null) {
            if (field.getName() == ApiConstants.JOB_ID) {
                return "long";
            }
            throw new NullPointerException("Data Type was null for field " + field.getName());
        } else {
            String origDataType = field.getDataType();
            Boolean isRequired = field.isRequired();
            if (isRequired == null) {
                isRequired = true;
            }

            switch (origDataType) {
            case "map":
                if (field.isRequestField()) {
                    return "IList<IDictionary<string, object>>";
                } else {
                    Type[] typeArgs = field.getGenericTypeArguments();
                    if (typeArgs != null && typeArgs.length > 0) {
                        return String.format("IDictionary<%s, %s>", convertJavaDataType(field.getGenericTypeArguments()[0]),
                                convertJavaDataType(field.getGenericTypeArguments()[1]));
                    } else {
                        return "IDictionary<string, string>";
                    }
                }
            case "set":
            case "list":
                if (field.getCollectionType() != null) {
                    return String.format("IList<%s>", convertCommandType(field.getCollectionType(), true));
                } else if (field.getGenericTypeArguments() != null && field.getGenericTypeArguments().length != 0) {
                    Type typeArg = field.getGenericTypeArguments()[0];
                    return String.format("IList<%s>", convertJavaDataType(typeArg));
                } else {
                    s_logger.warn("Set without Type Param for Field " + field.getName());
                }
            }

            String convertedCommandType = convertCommandType(origDataType, isRequired);
            if (convertedCommandType != null) {
                return convertedCommandType;
            }

            if (field.getJavaDataTypeName() != null) {
                // It's a non-trivial type
                return field.getJavaDataType().getSimpleName();
            }

            s_logger.warn("Didn't have mapping for data type " + origDataType);
            return origDataType;
        }
    }

    private String convertCommandType(String commandType, boolean isRequired) {
        switch (commandType) {
        case "string":
            return "string";
        case "uuid":
            return "Guid";
        case "long":
        case "short":
            return isRequired ? commandType : (commandType + "?");
        case "boolean":
            return isRequired ? "bool" : "bool?";
        case "integer":
        case "int":
            return isRequired ? "int" : "int?";
        case "date":
            return isRequired ? "DateTime" : "DateTime?";
        case "tzdate":
            return isRequired ? "DateTimeOffset" : "DateTimeOffset?";
        case "bigdecimal":
            return isRequired ? "decimal" : "decimal?";
        case "url":
            return "string";
        }

        return null;
    }

    private String convertJavaDataType(Type type) {
        String typeName = type.toString().substring("class ".length());

        String namespace = typeName.substring(0, typeName.lastIndexOf('.'));
        String simpleTypeName = typeName.substring(typeName.lastIndexOf('.') + 1);

        if (namespace.equals("java.lang")) {
            return simpleTypeName.toLowerCase();
        }
        return simpleTypeName;
    }
}