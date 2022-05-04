namespace glregistry;

public static partial class Resources {

    public const string IncludeFilename = OutputFolder + "/_include.cs";
    public const string IncludeCode = @"
global using System;
global using System.Runtime.InteropServices;
";

    public static readonly string[,] TypeTable = new string[,] {
        { "GLenum", "global using GLenum = System.UInt32;" },
        { "GLboolean", "global using GLboolean = System.Byte;" },
        { "GLbitfield", "global using GLbitfield = System.UInt32;" },
        { "GLbyte", "global using GLbyte = System.SByte;" },
        { "GLubyte", "global using GLubyte = System.Byte;" },
        { "GLshort", "global using GLshort = System.Int16;" },
        { "GLushort", "global using GLushort = System.UInt16;" },
        { "GLint", "global using GLint = System.Int32;" },
        { "GLuint", "global using GLuint = System.UInt32;" },
        { "GLclampx", "global using GLclampx = System.Int32;" },
        { "GLsizei", "global using GLsizei = System.Int32;" },
        { "GLfloat", "global using GLfloat = System.Single;" },
        { "GLclampf", "global using GLclampf = System.Single;" },
        { "GLdouble", "global using GLdouble = System.Double;" },
        { "GLclampd", "global using GLclampd = System.Double;" },
        { "GLchar", "global using GLchar = System.Byte;" },
        { "GLhalf", "global using GLhalf = System.UInt16;" },
        { "GLfixed", "global using GLfixed = System.Int32;" },
        { "GLintptr", "global using GLintptr = System.IntPtr;" },
        { "GLsizeiptr", "global using GLsizeiptr = System.UIntPtr;" },
        { "GLint64", "global using GLint64 = System.Int64;" },
        { "GLuint64", "global using GLuint64 = System.UInt64;" },

        // TODO : write definitions for each of the other callback delegates
        
        // delegates must appear after everything else and need extra line spacing
        { "GLDEBUGPROC", @"
unsafe public delegate void GLDEBUGPROC(DebugSource source, DebugType type, GLuint id, DebugSeverity sevirity, GLsizei length, GLchar* message, void* userParam);" }
    };

}