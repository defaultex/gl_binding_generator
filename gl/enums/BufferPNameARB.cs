#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_5 || GL_VERSION_ES_CM_1_0 || GL_ES_VERSION_3_0 || GL_VERSION_3_0 || GL_ARB_BUFFER_STORAGE || GL_VERSION_4_4 || GL_ARB_VERTEX_BUFFER_OBJECT)

public enum BufferPNameARB : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_5 || GL_VERSION_ES_CM_1_0)
    Size = gl.Constants.GL_BUFFER_SIZE, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_5 || GL_VERSION_ES_CM_1_0)
    Usage = gl.Constants.GL_BUFFER_USAGE, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_5)
    Mapped = gl.Constants.GL_BUFFER_MAPPED, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    AccessFlags = gl.Constants.GL_BUFFER_ACCESS_FLAGS, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    MapLength = gl.Constants.GL_BUFFER_MAP_LENGTH, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    MapOffset = gl.Constants.GL_BUFFER_MAP_OFFSET, 
#endif

#if GL_VERSION_1_5
    Access = gl.Constants.GL_BUFFER_ACCESS, 
#endif

#if (GL_ARB_BUFFER_STORAGE || GL_VERSION_4_4)
    ImmutableStorage = gl.Constants.GL_BUFFER_IMMUTABLE_STORAGE, 
#endif

#if (GL_ARB_BUFFER_STORAGE || GL_VERSION_4_4)
    StorageFlags = gl.Constants.GL_BUFFER_STORAGE_FLAGS, 
#endif

#if GL_ARB_VERTEX_BUFFER_OBJECT
    SizeArb = gl.Constants.GL_BUFFER_SIZE_ARB, 
#endif

#if GL_ARB_VERTEX_BUFFER_OBJECT
    UsageArb = gl.Constants.GL_BUFFER_USAGE_ARB, 
#endif

#if GL_ARB_VERTEX_BUFFER_OBJECT
    AccessArb = gl.Constants.GL_BUFFER_ACCESS_ARB, 
#endif

#if GL_ARB_VERTEX_BUFFER_OBJECT
    MappedArb = gl.Constants.GL_BUFFER_MAPPED_ARB, 
#endif

}

#endif
