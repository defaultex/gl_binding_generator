global using GLenum = System.UInt32;
global using GLboolean = System.Byte;
global using GLbitfield = System.UInt32;
global using GLbyte = System.SByte;
global using GLubyte = System.Byte;
global using GLshort = System.Int16;
global using GLushort = System.UInt16;
global using GLint = System.Int32;
global using GLuint = System.UInt32;
global using GLsizei = System.Int32;
global using GLfloat = System.Single;
global using GLdouble = System.Double;
global using GLchar = System.Byte;
global using GLintptr = System.IntPtr;
global using GLsizeiptr = System.UIntPtr;
global using GLint64 = System.Int64;
global using GLuint64 = System.UInt64;
global using GLeglImageOES = System.IntPtr;
global using GLint64EXT = System.Int64;
global using GLuint64EXT = System.UInt64;

global using System;
global using System.Runtime.InteropServices;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GLDEBUGPROC(DebugSource source, DebugType type, GLuint id, DebugSeverity sevirity, GLsizei length, IntPtr message, IntPtr userParam);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GLDEBUGPROCARB(DebugSource source, DebugType type, GLuint id, DebugSeverity sevirity, GLsizei length, IntPtr message, IntPtr userParam);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GLVULKANPROCNV();
