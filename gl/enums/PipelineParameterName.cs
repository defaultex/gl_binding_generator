#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0 || GL_ARB_SEPARATE_SHADER_OBJECTS || GL_ES_VERSION_3_1 || GL_VERSION_4_1 || GL_ES_VERSION_3_2 || GL_VERSION_3_2 || GL_ARB_TESSELLATION_SHADER || GL_VERSION_4_0)

public enum PipelineParameterName : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0)
    InfoLogLength = gl.Constants.GL_INFO_LOG_LENGTH, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0)
    FragmentShader = gl.Constants.GL_FRAGMENT_SHADER, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0)
    VertexShader = gl.Constants.GL_VERTEX_SHADER, 
#endif

#if (GL_ARB_SEPARATE_SHADER_OBJECTS || GL_ES_VERSION_3_1 || GL_VERSION_4_1)
    ActiveProgram = gl.Constants.GL_ACTIVE_PROGRAM, 
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

}

#endif
