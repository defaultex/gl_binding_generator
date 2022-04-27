#if (GL_VERSION_4_6 || GL_ARM_MALI_SHADER_BINARY || GL_DMP_SHADER_BINARY || GL_FJ_SHADER_BINARY_GCCSO || GL_IMG_SHADER_BINARY || GL_VIV_SHADER_BINARY)

public enum ShaderBinaryFormat : GLenum { 
#if GL_VERSION_4_6
    FormatSpirV = gl.Constants.GL_SHADER_BINARY_FORMAT_SPIR_V, 
#endif

#if GL_ARM_MALI_SHADER_BINARY
    MaliShaderBinaryArm = gl.Constants.GL_MALI_SHADER_BINARY_ARM, 
#endif

#if GL_DMP_SHADER_BINARY
    Dmp = gl.Constants.GL_SHADER_BINARY_DMP, 
#endif

#if GL_FJ_SHADER_BINARY_GCCSO
    GccsoShaderBinaryFj = gl.Constants.GL_GCCSO_SHADER_BINARY_FJ, 
#endif

#if GL_IMG_SHADER_BINARY
    SgxImg = gl.Constants.GL_SGX_BINARY_IMG, 
#endif

#if GL_VIV_SHADER_BINARY
    Viv = gl.Constants.GL_SHADER_BINARY_VIV, 
#endif

}

#endif
