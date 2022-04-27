#if GL_EXT_VERTEX_SHADER

public enum DataTypeEXT : GLenum { 
#if GL_EXT_VERTEX_SHADER
    ScalarExt = gl.Constants.GL_SCALAR_EXT, 
#endif

#if GL_EXT_VERTEX_SHADER
    VectorExt = gl.Constants.GL_VECTOR_EXT, 
#endif

#if GL_EXT_VERTEX_SHADER
    MatrixExt = gl.Constants.GL_MATRIX_EXT, 
#endif

}

#endif
