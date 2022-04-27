#if (GL_ARB_ENHANCED_LAYOUTS || GL_ES_VERSION_3_0 || GL_VERSION_3_0 || GL_VERSION_4_4 || GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_1 || GL_VERSION_4_3)

public enum ProgramInterface : GLenum { 
#if (GL_ARB_ENHANCED_LAYOUTS || GL_ES_VERSION_3_0 || GL_VERSION_3_0 || GL_VERSION_4_4)
    TransformFeedbackBuffer = gl.Constants.GL_TRANSFORM_FEEDBACK_BUFFER, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    Uniform = gl.Constants.GL_UNIFORM, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    UniformBlock = gl.Constants.GL_UNIFORM_BLOCK, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    Input = gl.Constants.GL_PROGRAM_INPUT, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    Output = gl.Constants.GL_PROGRAM_OUTPUT, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    BufferVariable = gl.Constants.GL_BUFFER_VARIABLE, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    ShaderStorageBlock = gl.Constants.GL_SHADER_STORAGE_BLOCK, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    TransformFeedbackVarying = gl.Constants.GL_TRANSFORM_FEEDBACK_VARYING, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_VERSION_4_3)
    VertexSubroutine = gl.Constants.GL_VERTEX_SUBROUTINE, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_VERSION_4_3)
    TessControlSubroutine = gl.Constants.GL_TESS_CONTROL_SUBROUTINE, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_VERSION_4_3)
    TessEvaluationSubroutine = gl.Constants.GL_TESS_EVALUATION_SUBROUTINE, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_VERSION_4_3)
    GeometrySubroutine = gl.Constants.GL_GEOMETRY_SUBROUTINE, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_VERSION_4_3)
    FragmentSubroutine = gl.Constants.GL_FRAGMENT_SUBROUTINE, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_VERSION_4_3)
    ComputeSubroutine = gl.Constants.GL_COMPUTE_SUBROUTINE, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_VERSION_4_3)
    VertexSubroutineUniform = gl.Constants.GL_VERTEX_SUBROUTINE_UNIFORM, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_VERSION_4_3)
    TessControlSubroutineUniform = gl.Constants.GL_TESS_CONTROL_SUBROUTINE_UNIFORM, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_VERSION_4_3)
    TessEvaluationSubroutineUniform = gl.Constants.GL_TESS_EVALUATION_SUBROUTINE_UNIFORM, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_VERSION_4_3)
    GeometrySubroutineUniform = gl.Constants.GL_GEOMETRY_SUBROUTINE_UNIFORM, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_VERSION_4_3)
    FragmentSubroutineUniform = gl.Constants.GL_FRAGMENT_SUBROUTINE_UNIFORM, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_VERSION_4_3)
    ComputeSubroutineUniform = gl.Constants.GL_COMPUTE_SUBROUTINE_UNIFORM, 
#endif

}

#endif
