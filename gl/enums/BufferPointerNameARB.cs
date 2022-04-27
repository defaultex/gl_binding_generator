#if (GL_ES_VERSION_3_0 || GL_VERSION_1_5 || GL_ARB_VERTEX_BUFFER_OBJECT)

public enum BufferPointerNameARB : GLenum { 
#if (GL_ES_VERSION_3_0 || GL_VERSION_1_5)
    MapPointer = gl.Constants.GL_BUFFER_MAP_POINTER, 
#endif

#if GL_ARB_VERTEX_BUFFER_OBJECT
    MapPointerArb = gl.Constants.GL_BUFFER_MAP_POINTER_ARB, 
#endif

}

#endif
