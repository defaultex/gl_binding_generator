#if (GL_ES_VERSION_2_0 || GL_EXT_RENDER_SNORM || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0 || GL_ARB_VERTEX_SHADER || GL_OES_TEXTURE_FLOAT || GL_ARB_GPU_SHADER_FP64 || GL_EXT_VERTEX_ATTRIB_64BIT || GL_VERSION_1_1)

public enum VertexPointerType : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_EXT_RENDER_SNORM || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Short = gl.Constants.GL_SHORT, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0)
    Int = gl.Constants.GL_INT, 
#endif

#if (GL_ARB_VERTEX_SHADER || GL_ES_VERSION_2_0 || GL_OES_TEXTURE_FLOAT || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Float = gl.Constants.GL_FLOAT, 
#endif

#if (GL_ARB_GPU_SHADER_FP64 || GL_EXT_VERTEX_ATTRIB_64BIT || GL_VERSION_1_1)
    Double = gl.Constants.GL_DOUBLE, 
#endif

}

#endif
