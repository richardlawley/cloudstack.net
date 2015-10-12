package com.cloud.api.doc;

import java.io.IOException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Iterator;
import java.util.List;
import java.util.Set;

import org.apache.cloudstack.api.APICommand;
import org.apache.log4j.ConsoleAppender;
import org.apache.log4j.Level;
import org.apache.log4j.Logger;
import org.apache.log4j.PatternLayout;

import com.cloud.utils.ReflectUtil;

public class ApiCommandProcessorProgram {
    private ApiCommandProcessor _processor;

    public ApiCommandProcessorProgram(ApiCommandProcessor processor) {
        _processor = processor;
    }

    public void Run(String[] args) {
        // Parse runtime arguments
        List<String> argsList = Arrays.asList(args);
        Iterator<String> iter = argsList.iterator();
        String[] fileNames = null;
        String dirName = null;
        while (iter.hasNext()) {
            String arg = iter.next();
            // populate the file names
            if (arg.equals("-f")) {
                fileNames = iter.next().split(",");
            }
            if (arg.equals("-d")) {
                dirName = iter.next();
            }
        }

        if ((fileNames == null) || (fileNames.length == 0)) {
            System.out.println("Please specify input file(s) separated by comma using -f option");
            System.exit(2);
        }

        // Namespaces to search for API commands
        List<String> namespaces = new ArrayList<String>();
        namespaces.add("org.apache.cloudstack.api");
        namespaces.add("com.cloud.api");
        namespaces.add("com.cloud.api.commands");
        namespaces.add("com.globo.globodns.cloudstack.api");
        namespaces.add("org.apache.cloudstack.network.opendaylight.api");
        namespaces.add("com.cloud.api.commands.netapp");
        namespaces.add("org.apache.cloudstack.api.command.admin.zone");
        namespaces.add("org.apache.cloudstack.network.contrail.api.command");

        // Use reflection to find classes annotated with APICommand
        Set<Class<?>> cmdClasses = ReflectUtil.getClassesWithAnnotation(APICommand.class, namespaces.toArray(new String[namespaces.size()]));
        _processor.addClasses(cmdClasses);

        // The config file defines the commands to include and their permissions
        for (String fileName : fileNames) {
            _processor.loadCommandsFromFile(fileName);
        }

        try {
            _processor.processApiCommands(dirName);
        } catch (IOException e) {
            e.printStackTrace(System.err);
            System.exit(1);
        }
    }
}
