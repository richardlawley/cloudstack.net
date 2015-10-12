// Licensed to the Apache Software Foundation (ASF) under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  The ASF licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.
package com.cloud.api.doc;

import java.io.Serializable;
import java.lang.reflect.Field;
import java.lang.reflect.ParameterizedType;
import java.lang.reflect.Type;
import java.util.ArrayList;
import java.util.Collection;
import java.util.Collections;
import java.util.HashSet;
import java.util.List;
import java.util.Set;

import org.apache.cloudstack.api.APICommand;
import org.apache.cloudstack.api.BaseAsyncCmd;
import org.apache.cloudstack.api.BaseAsyncCreateCmd;
import org.apache.cloudstack.api.BaseCmd;
import org.apache.cloudstack.api.BaseCmd.CommandType;
import org.apache.cloudstack.api.BaseListCmd;
import org.apache.cloudstack.api.BaseResponse;
import org.apache.cloudstack.api.EntityReference;
import org.apache.cloudstack.api.Parameter;
import org.apache.cloudstack.api.response.AsyncJobResponse;
import org.apache.log4j.Logger;

import com.cloud.serializer.Param;
import com.cloud.utils.IteratorUtil;
import com.cloud.utils.ReflectUtil;
import com.google.gson.annotations.SerializedName;

public class Command implements Serializable {
    private static final Logger s_logger = Logger.getLogger(Command.class.getName());
    private static List<String> s_asyncResponseClasses = new ArrayList<String>();

    public static void RegisterAsyncResponseClass(String className) {
        s_asyncResponseClasses.add(className);
    }

    /**
     *
     */
    private static final long serialVersionUID = -4318310162503004975L;
    private String name;
    private String description;
    private String usage;
    private boolean isAsync;
    private String sinceVersion = null;
    private ArrayList<Argument> request;
    private ArrayList<Argument> response;
    private String _responseType;
    private boolean _isList;
    private boolean _includeInDocumentation = true;
    private String _listContainerName;

    public Command(String name, Class<?> implementation) {
        this.name = name;

        ArrayList<Argument> request = new ArrayList<Argument>();
        ArrayList<Argument> response = new ArrayList<Argument>();

        APICommand annotation = implementation.getAnnotation(APICommand.class);
        if (annotation == null) {
            annotation = implementation.getSuperclass().getAnnotation(APICommand.class);
        }
        if (annotation == null) {
            throw new IllegalStateException(
                    String.format("An %1$s annotation is required for class %2$s.", APICommand.class.getCanonicalName(), implementation.getCanonicalName()));
        }
        Class<? extends BaseResponse> responseObject = annotation.responseObject();
        _responseType = responseObject.getName();

        try {
            BaseCmd commandInstance = (BaseCmd) implementation.newInstance();
            if (commandInstance instanceof BaseListCmd) {
                // BaseListCmd listCmd = (BaseListCmd) commandInstance;
                _isList = true;

                // The serialised name of the list will be the "entityType" of
                // the class.
                if (annotation.entityType() != null && annotation.entityType().length > 0) {
                    _listContainerName = annotation.entityType()[0].getSimpleName();
                } else {
                    // Look for an entity annotation on the referenced class
                    EntityReference entityAnnotation = responseObject.getAnnotation(EntityReference.class);
                    if (entityAnnotation != null && entityAnnotation.value().length > 0) {
                        _listContainerName = entityAnnotation.value()[0].getSimpleName();
                    }
                }
            }
        } catch (InstantiationException | IllegalAccessException e) {
            // TODO Auto-generated catch block
            e.printStackTrace();
        }

        _includeInDocumentation = annotation.includeInApiDoc();
        description = annotation.description();
        if (description == null || description.isEmpty()) {
            System.out.println(String.format("Command %s misses description", name));
        }

        usage = annotation.usage();

        // Set version when the API is added
        if (!annotation.since().isEmpty()) {
            sinceVersion = annotation.since();
        }

        isAsync = ReflectUtil.isCmdClassAsync(implementation, new Class<?>[] { BaseAsyncCmd.class, BaseAsyncCreateCmd.class });

        Set<Field> fields = ReflectUtil.getAllFieldsForClass(implementation, new Class<?>[] { BaseCmd.class, BaseAsyncCmd.class, BaseAsyncCreateCmd.class });

        request = createArgumentsFromRequestFields(fields);

        // Get response parameters
        Class<?> responseClas = annotation.responseObject();
        Field[] responseFields = responseClas.getDeclaredFields();
        response = createArgumentsFromResponseFields(responseFields, responseClas, name);

        setRequest(request);
        setResponse(response);

    }

    public Command() {
    }

    public String getName() {
        return name;
    }

    public String getDescription() {
        return description;
    }

    public boolean getIncludeInDocumentation() {
        return _includeInDocumentation;
    }

    public boolean isList() {
        return _isList;
    }

    public ArrayList<Argument> getRequest() {
        return request;
    }

    public void setRequest(ArrayList<Argument> request) {
        this.request = request;
    }

    public ArrayList<Argument> getResponse() {
        return response;
    }

    public String getResponseType() {
        return _responseType;
    }

    public void setResponse(ArrayList<Argument> response) {
        this.response = response;
    }

    public boolean isAsync() {
        return isAsync;
    }

    public String getSinceVersion() {
        return sinceVersion;
    }

    public String getListContainerName() {
        return _listContainerName;
    }

    public Argument getReqArgByName(String name) {
        for (Argument a : getRequest()) {
            if (a.getName().equals(name)) {
                return a;
            }
        }
        return null;
    }

    public Argument getResArgByName(String name) {
        for (Argument a : getResponse()) {
            if (a.getName().equals(name)) {
                return a;
            }
        }
        return null;
    }

    public String getUsage() {
        return usage;
    }

    private ArrayList<Argument> createArgumentsFromRequestFields(Set<Field> fields) {
        ArrayList<Argument> arguments = new ArrayList<Argument>();
        Set<Argument> requiredArguments = new HashSet<Argument>();
        Set<Argument> optionalArguments = new HashSet<Argument>();
        Argument id = null;

        HashSet<String> seenFields = new HashSet<String>();

        for (Field f : fields) {
            Parameter parameterAnnotation = f.getAnnotation(Parameter.class);
            if (parameterAnnotation != null && parameterAnnotation.expose() && parameterAnnotation.includeInApiDoc()) {
                String name = parameterAnnotation.name();
                if (seenFields.contains(name)) {
                    continue;
                }
                seenFields.add(name);

                Argument reqArg = new Argument(name, true);
                if (f.getName().equalsIgnoreCase(name)) {
                    reqArg.setNameWithCaps(f.getName().substring(0, 1).toUpperCase() + f.getName().substring(1));
                } else {
                    reqArg.setNameWithCaps(name.substring(0, 1).toUpperCase() + name.substring(1));
                }
                reqArg.setRequired(parameterAnnotation.required());
                reqArg.setJavaDataType(f.getType());
                reqArg.setJavaDataTypeName(f.getType().getSimpleName());

                if (f.getGenericType() != null) {
                    if (f.getGenericType() instanceof ParameterizedType) {
                        reqArg.setGenericTypeArguments(((ParameterizedType) f.getGenericType()).getActualTypeArguments());
                    }
                }

                if (!parameterAnnotation.description().isEmpty()) {
                    reqArg.setDescription(parameterAnnotation.description());
                }

                if (parameterAnnotation.type() == BaseCmd.CommandType.LIST || parameterAnnotation.type() == BaseCmd.CommandType.MAP) {
                    reqArg.setType(parameterAnnotation.type().toString().toLowerCase());
                    if (parameterAnnotation.type() == BaseCmd.CommandType.LIST && parameterAnnotation.collectionType() != CommandType.OBJECT) {
                        reqArg.setCollectionType(parameterAnnotation.collectionType().toString().toLowerCase());
                    }
                }

                reqArg.setDataType(parameterAnnotation.type().toString().toLowerCase());

                if (!parameterAnnotation.since().isEmpty()) {
                    reqArg.setSinceVersion(parameterAnnotation.since());
                }

                if (reqArg.isRequired()) {
                    if (parameterAnnotation.name().equals("id")) {
                        id = reqArg;
                    } else {
                        requiredArguments.add(reqArg);
                    }
                } else {
                    optionalArguments.add(reqArg);
                }
            }
        }

        // sort required and optional arguments here
        if (id != null) {
            arguments.add(id);
        }
        arguments.addAll(IteratorUtil.asSortedList(requiredArguments));
        arguments.addAll(IteratorUtil.asSortedList(optionalArguments));

        return arguments;
    }

    private ArrayList<Argument> createArgumentsFromResponseFields(Field[] responseFields, Class<?> responseClas, String commandName) {
        ArrayList<Argument> arguments = new ArrayList<Argument>();
        ArrayList<Argument> sortedChildlessArguments = new ArrayList<Argument>();
        ArrayList<Argument> sortedArguments = new ArrayList<Argument>();

        Argument id = null;

        for (Field f : responseFields) {
            SerializedName nameAnnotation = f.getAnnotation(SerializedName.class);
            if (nameAnnotation != null) {
                Param paramAnnotation = f.getAnnotation(Param.class);
                Argument respArg = new Argument(nameAnnotation.value(), false);

                if (f.getName().equalsIgnoreCase(nameAnnotation.value())) {
                    respArg.setNameWithCaps(f.getName().substring(0, 1).toUpperCase() + f.getName().substring(1));
                } else {
                    respArg.setNameWithCaps(nameAnnotation.value().substring(0, 1).toUpperCase() + nameAnnotation.value().substring(1));
                }

                if (f.getGenericType() != null) {
                    if (f.getGenericType() instanceof ParameterizedType) {
                        respArg.setGenericTypeArguments(((ParameterizedType) f.getGenericType()).getActualTypeArguments());
                    }
                }

                boolean hasChildren = false;
                if (paramAnnotation != null && paramAnnotation.includeInApiDoc()) {

                    respArg.setDataType(f.getType().getSimpleName().toLowerCase());
                    if (f.getType().getName().indexOf('.') != -1 && !f.getType().getName().startsWith("java.")) {
                        respArg.setJavaDataType(f.getType());
                        respArg.setJavaDataTypeName(f.getType().getSimpleName());
                    }

                    String description = paramAnnotation.description();
                    if (description != null && !description.isEmpty()) {
                        respArg.setDescription(description);
                    }

                    if (!paramAnnotation.since().isEmpty()) {
                        respArg.setSinceVersion(paramAnnotation.since());
                    }

                    Class<?> fieldClass = paramAnnotation.responseObject();
                    if (fieldClass == Object.class) {
                        // If the annotation didn't contain a response attribute, the fieldClass defaults to object
                        // fieldClass = f.getClass();
                    }

                    if (fieldClass != null) {
                        if (f.getType().isEnum()) {
                            // respArg.setJavaDataType(f.getType());
                            // String enumName = f.getType().getSimpleName();
                            // respArg.setJavaDataTypeName(enumName);
                        } else {
                            Class<?> superClass = fieldClass.getSuperclass();
                            if (superClass != null) {
                                String superName = superClass.getName();
                                if (superName.equals(BaseResponse.class.getName())) {
                                    ArrayList<Argument> fieldArguments = new ArrayList<Argument>();
                                    Field[] fields = fieldClass.getDeclaredFields();
                                    fieldArguments = createArgumentsFromResponseFields(fields, fieldClass, commandName);
                                    respArg.setArguments(fieldArguments);
                                    respArg.setJavaDataType(fieldClass);
                                    respArg.setJavaDataTypeName(fieldClass.getSimpleName());
                                    hasChildren = true;
                                }
                            } else if (Collection.class.isAssignableFrom(f.getType())) {
                                if (respArg.getGenericTypeArguments() != null && respArg.getGenericTypeArguments().length > 0) {
                                    for (Type type : respArg.getGenericTypeArguments()) {
                                        String typeName = type.toString().substring("class ".length());

                                        if (!typeName.startsWith("java.lang")) {
                                            // Complex type param, should've been told about it by the responseObject annotation
                                            s_logger.warn(String.format("%s.%s - Collection without responseObject annotation (%s)", commandName, f.getName(), typeName));
                                        }
                                    }
                                } else {
                                    // This was a collection but there was no type assigned
                                    s_logger.warn(String.format("%s.%s - Collection without responseObject or Generic Type Argument", commandName, f.getName()));
                                }
                            }
                        }
                    }
                }

                if (paramAnnotation != null && paramAnnotation.includeInApiDoc()) {
                    if (nameAnnotation.value().equals("id")) {
                        id = respArg;
                    } else {
                        if (hasChildren) {
                            respArg.setName(nameAnnotation.value() + "(*)");
                            sortedArguments.add(respArg);
                        } else {
                            sortedChildlessArguments.add(respArg);
                        }
                    }
                }
            }
        }

        Collections.sort(sortedArguments);
        Collections.sort(sortedChildlessArguments);

        if (id != null) {
            arguments.add(id);
        }
        arguments.addAll(sortedChildlessArguments);
        arguments.addAll(sortedArguments);

//        if (responseClas.getName().equalsIgnoreCase(AsyncJobResponse.class.getName())) {
//            Argument jobIdArg = new Argument("jobid", "the ID of the async job");
//            arguments.add(jobIdArg);
//        } else if (s_asyncResponseClasses.contains(responseClas.getName())) {
//            Argument jobIdArg = new Argument("jobid", "the ID of the latest async job acting on this object");
//            Argument jobStatusArg = new Argument("jobstatus", "the current status of the latest async job acting on this object");
//            jobIdArg.setDataType("uuid");
//            jobIdArg.setRequired(false);
//            jobStatusArg.setDataType("string");
//            arguments.add(jobIdArg);
//            arguments.add(jobStatusArg);
//        }

        return arguments;
    }
}
