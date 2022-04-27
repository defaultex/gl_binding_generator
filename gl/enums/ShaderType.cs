#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0 || GL_ARB_COMPUTE_SHADER || GL_ES_VERSION_3_1 || GL_VERSION_4_3 || GL_ES_VERSION_3_2 || GL_VERSION_3_2 || GL_ARB_TESSELLATION_SHADER || GL_VERSION_4_0 || GL_ARB_FRAGMENT_SHADER || GL_ARB_VERTEX_SHADER)

public enum ShaderType : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0)
    FragmentShader = gl.Constants.GL_FRAGMENT_SHADER, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0)
    VertexShader = gl.Constants.GL_VERTEX_SHADER, 
#endif

#if (GL_ARB_COMPUTE_SHADER || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    ComputeShader = gl.Constants.GL_COMPUTE_SHADER, 
#endif

#if (GL_ES_VERSION_3_2 || GL_VERSION_3_2)
    GeometryShader = gl.Constants.GL_GEOMETRY_SHADER, 
#endif

#if (GL_ARB_TESSELLATION_SHADER || GL_ES_VERSION_3_2 || GL_VERSION_4_0)
    TessEvaluationShader = gl.Constants.GL_TESS_EVALUATION_SHADER, 
#endif

#if (GL_ARB_TESSELLATION_SHADER || GL_ES_VERSION_3_2 || GL_VERSION_4_0)
    TessControlShader = gl.Constants.GL_TESS_CONTROL_SHADER, 
#endif

#if GL_ARB_FRAGMENT_SHADER
    FragmentShaderArb = gl.Constants.GL_FRAGMENT_SHADER_ARB, 
#endif

#if GL_ARB_VERTEX_SHADER
    VertexShaderArb = gl.Constants.GL_VERTEX_SHADER_ARB, 
#endif

}

#endif
