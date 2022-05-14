# WARNING
This library is a work in progress. If you decide to use it in it's current state, be sure to review any changes should you decide to update your local copy as the changes could be small or they could be large. Currently the bulk of these changes will be in the enumerants and their respective groups (enums in C# terms).

# gl_binding_generator
Generates C# bindings intended for use with C# 10.0 and .Net 6. 
* Features are generated based on arguments provided to the generator, currently stored in 'launch.json' under the 'args' property. These arguments mirror the arguments provided to the python script on the OpenGL registry repository.
* Extensions are enabled based on constants provided in the generated project. Add an xml element to 'gl.csproj' in the 'PropertyGroup' element called 'DefinedConstants' and separate each extension name with a semi-colon. For example: GL_3DFX_multisample.
* OpenGL's type definitions are approximated using global usings for data types and unmanaged structures to preserve object identity. These objects can be found in the 'objects' folder in the generated project. The data types can be found in '_include.cs' in the generated project.
* Feature and extension constants are written into a file named 'gl.Constants.cs' in the appropriate feature or extension folder as constant values of the appropriate type.
* Feature and extension functions are written into a file named 'gl.Functions.cs' in the appropriate feature or extension folder as unmanaged function pointers. See binding notes below for how to use them.
* Enums are written into the 'enums' folder of the feature or extension their enumerants are first defined in, some may not be sorted correctly. Entries in a enumeration that are provided by an extension are header guarded to ensure they do not show up until their respective extensions are enabled.

# Binding Notes
* The function pointers defined by features and extensions are intended to be mapped to the address returned by GetProcAddress.
* This is accomplished by reflecting all of the static fields in the '.Functions' namespaces and calling GetProcAddress using the field name.
* To set the address the field points to, use 'SetValue(null, address)' on the reflected FieldInfo. If your unfamiliar with the syntax, passing 'null' as the first argument sets the static implementation instead of an instanced implementation of the field.
* The function pointer will be invoked using the 'calli' intrinsic, so care must be taken to massage all data going in and out (i.e. marshalling).
* The binding process must be repeated any time the context is lost since the pointers will likely not match up a that point. Testing is needed to determine if this is really the case as it's a suspicion based on the vague descriptions provided by GLFW and OpenGL about how the context side of things works.
* An example of what this process would look like can be seen in 'props/Resources.binding.cs' of the 'glregistry' project. That's a half-baked attempt to give the generator something to write into the binding but currently commented out with no code to actually write it to file in place. While I would normally just move such a thing into an external folder for the time being, I left it in place to serve as a kind-of demonstration of the concept.
