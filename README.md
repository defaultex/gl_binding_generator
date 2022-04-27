# gl_binding_generator

Generates C# bindings intended for use with C# 10.0 and .Net 6. 
* Features and Extensions are enabled by listing them in the defined constants.
* APIs are specified with NAME_API: GL_API, GLCORE_API, GLES1_API, GLES2_API, and GLSC2_API.
* Features are specified with their names: GL_VERSION_N_M, GL_ES_VERSION_N_M, and GL_VERSION_ES_CM_N_M. Where N is the major version and M the minor version.
* Extensions are specified with their names, for example: GL_3DFX_multisample. 
* Header guards are used extensive to ensure duplicate constants are not loaded.
* OpenGL's type definitions are approximated using global usings for data types and unmanaged structures to preserve object identity. These objects can be found in the 'objects' folder of the binding.
* Feature and extension constants are written into a file named 'gl.Constants.cs' in the appropriate feature or extension folder as constant values of the appropriate type.
* Feature and extension functions are written into a file named 'gl.Functions.cs' in the appropriate feature or extension folder as unmanaged function pointers. See binding notes below.

# Binding Notes
* The function pointers defined by features and extensions are intended to be mapped to the address returned by GetProcAddress.
* This is accomplished by reflecting all of the static fields in the '.Functions' namespaces and calling GetProcAddress using the field name.
* To set the address the field points to, use '.SetValue(null, address)' on the reflected FieldInfo.
* The function pointer will be invoked by the CIL using the 'calli' intrinsic, so care must be taken to massage all data going in and out (i.e. marshalling).

# Summary
The algorithm for producing the output code is based around a set of hand written bindings for OpenGL 3.3. When it got to the point refining the binding produced code that could be automatically produced, I decided to split it out into another project and codify the algorithm. This lead to improvements on the idea like header guards to solve conflicts like OpenGL 3.0 and OpenGL 3.1 both adding the same functions to the feature set automatically. The same header guards were then useful for determining which constants and functions to enable in the resulting project, something that was in my hand written version a manual process looking at my system's 'glext.h'.

The goal being to also generate accompanying safe C# wrappers around the functions that massage pointers where possible to avoid heavy marshalling typically incurred by interop. Since function pointers are invoked with 'calli' and C#'s equivalent types to GL's data types are actually equivalent, a lot of expensive interop can be avoided in an unsafe context.
