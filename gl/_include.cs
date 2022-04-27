global using GLenum = System.UInt32;
global using GLboolean = System.Byte;
global using GLbitfield = System.UInt32;
global using GLbyte = System.SByte;
global using GLubyte = System.Byte;
global using GLshort = System.Int16;
global using GLushort = System.UInt16;
global using GLint = System.Int32;
global using GLuint = System.UInt32;
global using GLclampx = System.Int32;
global using GLsizei = System.Int32;
global using GLfloat = System.Single;
global using GLclampf = System.Single;
global using GLdouble = System.Double;
global using GLclampd = System.Double;
global using GLchar = System.Byte;
global using GLhalf = System.UInt16;
global using GLfixed = System.Int32;
global using GLintptr = System.IntPtr;
global using GLsizeiptr = System.UIntPtr;
global using GLint64 = System.Int64;
global using GLuint64 = System.UInt64;

global using System;
global using System.Runtime.InteropServices;

unsafe public delegate void GLDEBUGPROC(DebugSource source, DebugType type, GLuint id, DebugSeverity sevirity, GLsizei length, GLchar* message, void* userParam);
