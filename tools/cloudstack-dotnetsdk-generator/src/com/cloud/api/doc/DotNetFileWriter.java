package com.cloud.api.doc;

import java.io.File;
import java.io.IOException;
import java.io.PrintWriter;

public class DotNetFileWriter implements AutoCloseable {

    private IndentWriter _writer;
    private boolean _namespaceOpen = false;
    private boolean _openDefinition = false;

    public DotNetFileWriter(File file) throws IOException {
        if (!file.createNewFile()) {
            throw new java.io.IOException(String.format("File %s already exists", file.getPath()));
        }

        _writer = new IndentWriter(new PrintWriter(file), "    ");
    }

    public DotNetFileWriter(File file, String namespace, String[] imports) throws IOException {
        this(file);

        println("using System;");
        if (imports != null) {
            for (String importLine : imports) {
                println("using %s;", importLine);
            }
        }
        println();

        println("namespace %s", namespace);
        println("{");
        incrementIndent();
        _namespaceOpen = true;
    }

    public DotNetFileWriter(String baseDirectory, String namespace, String[] imports, String typeName, String type) throws IOException {
        this(new File(baseDirectory, typeName + ".cs"), namespace, imports);

        addType(typeName, type);
    }

    public DotNetFileWriter(String fileName, String namespace, String[] imports) throws IOException {
        this(new File(fileName), namespace, imports);
    }

    public DotNetFileWriter(String baseDirectory, String namespace, String[] imports, String typeName) throws IOException {
        this(baseDirectory, namespace, imports, typeName, "class");
    }

    public void addType(String typeName, String type) {
        println("public %s %s", type, typeName);
        println("{");
        incrementIndent();
        _openDefinition = true;
    }

    public void addType(String typeName) {
        addType(typeName, "class");
    }

    public void closeTypeDef() {
        if (_openDefinition) {
            decrementIndent();
            println("}");
            _openDefinition = false;
        }
    }

    public void incrementIndent() {
        _writer.incrementIndent();
    }

    public void decrementIndent() {
        _writer.decrementIndent();
    }

    public void println() {
        _writer.println();
    }

    public void println(String format, Object... args) {
        _writer.println(format, args);
    }

    @Override
    public void close() throws Exception {
        if (_openDefinition) {
            closeTypeDef();
        }

        if (_namespaceOpen) {
            decrementIndent();
            println("}");
        }

        if (_writer.getIndentLevel() > 0) {
            throw new Exception("Indent level was non-zero at close - mismatched incrementIndent");
        }

        _writer.flush();
    }
}
