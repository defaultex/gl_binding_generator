#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_5 || GL_VERSION_ES_CM_1_0 || GL_ES_VERSION_3_0)

public enum VertexBufferObjectUsage : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_5)
    StreamDraw = gl.Constants.GL_STREAM_DRAW, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_5 || GL_VERSION_ES_CM_1_0)
    StaticDraw = gl.Constants.GL_STATIC_DRAW, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_5 || GL_VERSION_ES_CM_1_0)
    DynamicDraw = gl.Constants.GL_DYNAMIC_DRAW, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_5)
    StreamRead = gl.Constants.GL_STREAM_READ, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_5)
    StreamCopy = gl.Constants.GL_STREAM_COPY, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_5)
    StaticRead = gl.Constants.GL_STATIC_READ, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_5)
    StaticCopy = gl.Constants.GL_STATIC_COPY, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_5)
    DynamicRead = gl.Constants.GL_DYNAMIC_READ, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_5)
    DynamicCopy = gl.Constants.GL_DYNAMIC_COPY, 
#endif

}

#endif
