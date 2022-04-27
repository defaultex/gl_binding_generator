#if (GL_ES_VERSION_3_1 || GL_VERSION_1_5 || GL_NV_SHADER_BUFFER_STORE)

public enum BufferAccessARB : GLenum { 
#if (GL_ES_VERSION_3_1 || GL_VERSION_1_5)
    ReadOnly = gl.Constants.GL_READ_ONLY, 
#endif

#if (GL_ES_VERSION_3_1 || GL_NV_SHADER_BUFFER_STORE || GL_VERSION_1_5)
    WriteOnly = gl.Constants.GL_WRITE_ONLY, 
#endif

#if (GL_ES_VERSION_3_1 || GL_NV_SHADER_BUFFER_STORE || GL_VERSION_1_5)
    ReadWrite = gl.Constants.GL_READ_WRITE, 
#endif

}

#endif
