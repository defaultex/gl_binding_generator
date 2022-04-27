#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_5 || GL_VERSION_ES_CM_1_0 || GL_ES_VERSION_3_0 || GL_VERSION_3_0 || GL_ARB_BUFFER_STORAGE || GL_VERSION_4_4)

public enum VertexBufferObjectParameter : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_5 || GL_VERSION_ES_CM_1_0)
    BufferSize = gl.Constants.GL_BUFFER_SIZE, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_5 || GL_VERSION_ES_CM_1_0)
    BufferUsage = gl.Constants.GL_BUFFER_USAGE, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_5)
    BufferMapped = gl.Constants.GL_BUFFER_MAPPED, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    BufferAccessFlags = gl.Constants.GL_BUFFER_ACCESS_FLAGS, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    BufferMapLength = gl.Constants.GL_BUFFER_MAP_LENGTH, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    BufferMapOffset = gl.Constants.GL_BUFFER_MAP_OFFSET, 
#endif

#if GL_VERSION_1_5
    BufferAccess = gl.Constants.GL_BUFFER_ACCESS, 
#endif

#if (GL_ARB_BUFFER_STORAGE || GL_VERSION_4_4)
    BufferImmutableStorage = gl.Constants.GL_BUFFER_IMMUTABLE_STORAGE, 
#endif

#if (GL_ARB_BUFFER_STORAGE || GL_VERSION_4_4)
    BufferStorageFlags = gl.Constants.GL_BUFFER_STORAGE_FLAGS, 
#endif

}

#endif
