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

import java.lang.reflect.Type;
import java.util.List;

public class Argument implements Comparable {
    private String name;
    private String nameWithCaps;
    private String description;
    private Boolean required;
    private String type;
    private String collectionType;
    private String sinceVersion = null;
    private List<Argument> arguments;
    private String dataType;
    private Type[] _genericTypeArguments;
    private boolean isRequestField;

    private Class<?> _javaDataType;
    private String _javaDataTypeName;

    public Argument(String name, boolean isRequestField) {
        this.name = name;
        this.isRequestField = isRequestField;
    }

    public Argument(String name, String description, boolean required) {
        this.name = name;
        this.description = description;
        this.required = required;
    }

    public Argument(String name, String description) {
        this.name = name;
        this.description = description;
    }

    public String getNameWithCaps() {
        if (this.nameWithCaps == null) {
            return this.getName();
        }
        return this.nameWithCaps;
    }

    public void setNameWithCaps(String nameWithCaps) {
        this.nameWithCaps = nameWithCaps;
    }

    public String getType() {
        return this.type;
    }

    public Type[] getGenericTypeArguments() {
        return _genericTypeArguments;
    }

    public void setGenericTypeArguments(Type[] newValue) {
        _genericTypeArguments = newValue;
    }

    public void setType(String type) {
        this.type = type;
    }

    public String getCollectionType() {
        return this.collectionType;
    }

    public void setCollectionType(String collectionType) {
        this.collectionType = collectionType;
    }

    public void setDataType(String dataType) {
        this.dataType = dataType;
    }

    public String getDataType() {
        return this.dataType;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public Boolean isRequired() {
        return required;
    }

    public void setRequired(Boolean required) {
        this.required = required;
    }

    public List<Argument> getArguments() {
        return arguments;
    }

    public void setArguments(List<Argument> arguments) {
        this.arguments = arguments;
    }

    public String getSinceVersion() {
        return sinceVersion;
    }

    public String getJavaDataTypeName() {
        return _javaDataTypeName;
    }

    public void setJavaDataTypeName(String javaDataTypeName) {
        this._javaDataTypeName = javaDataTypeName;
    }

    public Class<?> getJavaDataType() {
        return this._javaDataType;
    }

    public void setJavaDataType(Class<?> responseDataType) {
        this._javaDataType = responseDataType;
    }

    public void setSinceVersion(String sinceVersion) {
        this.sinceVersion = sinceVersion;
    }

    public boolean isRequestField() {
        return this.isRequestField;
    }

    @Override
    public int compareTo(Object anotherAgrument) throws ClassCastException {
        if (!(anotherAgrument instanceof Argument))
            throw new ClassCastException("An Argument object expected.");
        Argument argument = (Argument) anotherAgrument;
        return this.getName().compareToIgnoreCase(argument.getName());
    }

    public boolean hasArguments() {
        return (arguments != null && !arguments.isEmpty());
    }

    @Override
    public String toString() {
        return "name=" + this.name + ", description=" + description + ", required=" + required + ", type=" + this.type + ", sinceVersion=" + this.sinceVersion + ", arguments="
                + this.arguments + ", dataType=" + this.dataType;
    }
}
