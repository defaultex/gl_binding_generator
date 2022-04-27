#if GL_EXT_VERTEX_SHADER

public enum VertexShaderStorageTypeEXT : GLenum { 
#if GL_EXT_VERTEX_SHADER
    VariantExt = gl.Constants.GL_VARIANT_EXT, 
#endif

#if GL_EXT_VERTEX_SHADER
    InvariantExt = gl.Constants.GL_INVARIANT_EXT, 
#endif

#if GL_EXT_VERTEX_SHADER
    LocalConstantExt = gl.Constants.GL_LOCAL_CONSTANT_EXT, 
#endif

#if GL_EXT_VERTEX_SHADER
    LocalExt = gl.Constants.GL_LOCAL_EXT, 
#endif

}

#endif
