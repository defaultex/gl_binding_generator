#if (GL_ARB_FRAGMENT_PROGRAM || GL_ARB_VERTEX_PROGRAM || GL_ATI_TEXT_FRAGMENT_SHADER || GL_NV_COMPUTE_PROGRAM5 || GL_NV_GEOMETRY_PROGRAM4 || GL_NV_TESSELLATION_PROGRAM5)

public enum ProgramTarget : GLenum { 
#if GL_ARB_FRAGMENT_PROGRAM
    FragmentProgramArb = gl.Constants.GL_FRAGMENT_PROGRAM_ARB, 
#endif

#if GL_ARB_VERTEX_PROGRAM
    VertexProgramArb = gl.Constants.GL_VERTEX_PROGRAM_ARB, 
#endif

#if GL_ATI_TEXT_FRAGMENT_SHADER
    TextFragmentShaderAti = gl.Constants.GL_TEXT_FRAGMENT_SHADER_ATI, 
#endif

#if GL_NV_COMPUTE_PROGRAM5
    ComputeProgramNv = gl.Constants.GL_COMPUTE_PROGRAM_NV, 
#endif

#if GL_NV_GEOMETRY_PROGRAM4
    GeometryProgramNv = gl.Constants.GL_GEOMETRY_PROGRAM_NV, 
#endif

#if GL_NV_TESSELLATION_PROGRAM5
    TessControlProgramNv = gl.Constants.GL_TESS_CONTROL_PROGRAM_NV, 
#endif

#if GL_NV_TESSELLATION_PROGRAM5
    TessEvaluationProgramNv = gl.Constants.GL_TESS_EVALUATION_PROGRAM_NV, 
#endif

}

#endif
