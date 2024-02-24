namespace glregistry;

public static partial class Resources {

    public const string IncludeFilename = OutputFolder + "/_include.cs";
    public const string IncludeCode = @"
global using System;
global using System.Runtime.InteropServices;
";

    public static readonly string[,] TypeTable = new string[,] {
        // gl data types
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

        // extension data types
        { "GLeglClientBufferEXT", "global using GLeglClientBufferEXT = System.IntPtr;"},
        { "GLeglImageOES", "global using GLeglImageOES = System.IntPtr;"},
        { "GLcharARB", "global using GLcharARB = System.Byte;" },
        { "GLhandleARB", "global using GLhandleARB = System.UInt32;" },
        { "GLhalfARB", "global using GLhalfARB = System.UInt16;" },
        { "GLintptrARB", "global using GLintptrARB = System.IntPtr;" },
        { "GLsizeiptrEXT", "global using GLsizeiptrEXT = System.UIntPtr;" },
        { "GLint64EXT", "global using GLint64EXT = System.Int64;" },
        { "GLuint64EXT", "global using GLuint64EXT = System.UInt64;" },

        // TODO : figure out definitions for the two OpenCL types
        
        // delegates must appear after everything else and need extra line spacing
        { "GLDEBUGPROC", @"
public delegate void GLDEBUGPROC(DebugSource source, DebugType type, GLuint id, DebugSeverity sevirity, GLsizei length, IntPtr message, IntPtr userParam);" },
        { "GLDEBUGPROCARB", @"
public delegate void GLDEBUGPROCARB(DebugSource source, DebugType type, GLuint id, DebugSeverity sevirity, GLsizei length, IntPtr message, IntPtr userParam);" },
        { "GLDEBUGPROCKHR", @"
public delegate void GLDEBUGPROCKHR(DebugSource source, DebugType type, GLuint id, DebugSeverity sevirity, GLsizei length, IntPtr message, IntPtr userParam);" },
        { "GLDEBUGPROCAMD", @"
public delegate void GLDEBUGPROCAMD(DebugSource source, DebugType type, GLuint id, DebugSeverity sevirity, GLsizei length, IntPtr message, IntPtr userParam);" },
        { "GLVULKANPROCNV", @"
public delegate void GLVULKANPROCNV();" }
    };

}