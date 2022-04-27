#if (GL_ARB_GPU_SHADER_FP64 || GL_EXT_VERTEX_ATTRIB_64BIT || GL_VERSION_1_1)

public enum VertexAttribLType : GLenum { 
#if (GL_ARB_GPU_SHADER_FP64 || GL_EXT_VERTEX_ATTRIB_64BIT || GL_VERSION_1_1)
    Double = gl.Constants.GL_DOUBLE, 
#endif

}

#endif
