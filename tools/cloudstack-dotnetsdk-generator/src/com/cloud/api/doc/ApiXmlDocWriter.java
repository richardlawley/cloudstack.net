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

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.io.ObjectOutputStream;
import java.lang.reflect.Field;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Map;

import org.apache.log4j.Logger;

import com.cloud.alert.AlertManager;
import com.thoughtworks.xstream.XStream;

public class ApiXmlDocWriter extends ApiCommandProcessor {
    public static final Logger s_logger = Logger.getLogger(ApiXmlDocWriter.class.getName());

    public static void main(String[] args) {
        new ApiCommandProcessorProgram(new ApiXmlDocWriter()).Run(args);
    }

    @Override
    protected void WriteResultsCore(String baseDirectory, Map<String, Command> commands, List<String> allCommandNames, List<String> domainAdminCommandNames,
            List<String> userCommandNames) {

        try {
            // Create object writer
            XStream xs = new XStream();
            xs.alias("command", Command.class);
            xs.alias("arg", Argument.class);
            String xmlDocDir = baseDirectory + "/xmldoc";
            String rootAdminDirName = xmlDocDir + "/root_admin";
            String domainAdminDirName = xmlDocDir + "/domain_admin";
            String regularUserDirName = xmlDocDir + "/regular_user";
            (new File(rootAdminDirName)).mkdirs();
            (new File(domainAdminDirName)).mkdirs();
            (new File(regularUserDirName)).mkdirs();

            ObjectOutputStream out = xs.createObjectOutputStream(new FileWriter(baseDirectory + "/commands.xml"), "commands");
            ObjectOutputStream rootAdmin = xs.createObjectOutputStream(new FileWriter(rootAdminDirName + "/" + "rootAdminSummary.xml"), "commands");
            ObjectOutputStream rootAdminSorted = xs.createObjectOutputStream(new FileWriter(rootAdminDirName + "/" + "rootAdminSummarySorted.xml"), "commands");
            ObjectOutputStream domainAdmin = xs.createObjectOutputStream(new FileWriter(domainAdminDirName + "/" + "domainAdminSummary.xml"), "commands");
            ObjectOutputStream outDomainAdminSorted = xs.createObjectOutputStream(new FileWriter(domainAdminDirName + "/" + "domainAdminSummarySorted.xml"), "commands");
            ObjectOutputStream regularUser = xs.createObjectOutputStream(new FileWriter(regularUserDirName + "/regularUserSummary.xml"), "commands");
            ObjectOutputStream regularUserSorted = xs.createObjectOutputStream(new FileWriter(regularUserDirName + "/regularUserSummarySorted.xml"), "commands");

            // Write commands in the order they are represented in commands.properties.in file
            for (String commandName : allCommandNames) {
                Command command = commands.get(commandName);
                if (command != null) {
                    out.writeObject(command);
                    rootAdmin.writeObject(command);

                    // Write single commands to separate xml files
                    ObjectOutputStream singleRootAdminCommandOs = xs.createObjectOutputStream(new FileWriter(rootAdminDirName + "/" + commandName + ".xml"), "command");
                    singleRootAdminCommandOs.writeObject(command);
                    singleRootAdminCommandOs.close();

                    if (domainAdminCommandNames.contains(commandName)) {
                        domainAdmin.writeObject(command);
                        ObjectOutputStream singleDomainAdminCommandOs = xs.createObjectOutputStream(new FileWriter(domainAdminDirName + "/" + commandName + ".xml"), "command");
                        singleDomainAdminCommandOs.writeObject(command);
                        singleDomainAdminCommandOs.close();
                    }

                    if (userCommandNames.contains(commandName)) {
                        regularUser.writeObject(command);
                        ObjectOutputStream singleRegularUserCommandOs = xs.createObjectOutputStream(new FileWriter(regularUserDirName + "/" + commandName + ".xml"), "command");
                        singleRegularUserCommandOs.writeObject(command);
                        singleRegularUserCommandOs.close();
                    }
                }
            }

            List<String> sortedCommands = new ArrayList<String>(allCommandNames);
            Collections.sort(sortedCommands);
            for (String commandName : sortedCommands) {
                Command command = commands.get(commandName);
                rootAdminSorted.writeObject(command);
                if (domainAdminCommandNames.contains(commandName)) {
                    outDomainAdminSorted.writeObject(command);
                }
                if (userCommandNames.contains(commandName)) {
                    regularUserSorted.writeObject(command);
                }
            }

            out.close();
            rootAdmin.close();
            rootAdminSorted.close();
            domainAdmin.close();
            outDomainAdminSorted.close();
            regularUser.close();
            regularUserSorted.close();

            // write alerttypes to xml
            writeAlertTypes(xmlDocDir);

            System.out.println("API Documentation Generated");

        } catch (Exception ex) {
            ex.printStackTrace();
            System.exit(2);
        }
    }

    private static void writeAlertTypes(String dirName) {
        XStream xs = new XStream();
        xs.alias("alert", Alert.class);
        try (ObjectOutputStream out = xs.createObjectOutputStream(new FileWriter(dirName + "/alert_types.xml"), "alerts");) {
            for (Field f : AlertManager.class.getFields()) {
                if (f.getClass().isAssignableFrom(Number.class)) {
                    String name = f.getName().substring(11);
                    Alert alert = new Alert(name, f.getInt(null));
                    out.writeObject(alert);
                }
            }
        } catch (IOException e) {
            s_logger.error("Failed to create output stream to write an alert types ", e);
        } catch (IllegalAccessException e) {
            s_logger.error("Failed to read alert fields ", e);
        }
    }
}