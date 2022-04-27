#if GL_EXT_VERTEX_SHADER

public enum VertexShaderParameterEXT : GLenum { 
#if GL_EXT_VERTEX_SHADER
    CurrentVertexExt = gl.Constants.GL_CURRENT_VERTEX_EXT, 
#endif

#if GL_EXT_VERTEX_SHADER
    MvpMatrixExt = gl.Constants.GL_MVP_MATRIX_EXT, 
#endif

}

#endif
