#if GL_EXT_MEMORY_OBJECT

public enum MemoryObjectParameterName : GLenum { 
#if GL_EXT_MEMORY_OBJECT
    DedicatedMemoryObjectExt = gl.Constants.GL_DEDICATED_MEMORY_OBJECT_EXT, 
#endif

#if GL_EXT_MEMORY_OBJECT
    ProtectedMemoryObjectExt = gl.Constants.GL_PROTECTED_MEMORY_OBJECT_EXT, 
#endif

}

#endif
