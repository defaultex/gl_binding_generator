#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_1 || GL_VERSION_4_3 || GL_ES_VERSION_3_2 || GL_ARB_SHADER_SUBROUTINE || GL_VERSION_4_0 || GL_ARB_ENHANCED_LAYOUTS || GL_VERSION_4_4)

public enum ProgramResourceProperty : GLenum { 
#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    Uniform = gl.Constants.GL_UNIFORM, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    NameLength = gl.Constants.GL_NAME_LENGTH, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    Type = gl.Constants.GL_TYPE, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    ArraySize = gl.Constants.GL_ARRAY_SIZE, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    Offset = gl.Constants.GL_OFFSET, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    BlockIndex = gl.Constants.GL_BLOCK_INDEX, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    ArrayStride = gl.Constants.GL_ARRAY_STRIDE, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    MatrixStride = gl.Constants.GL_MATRIX_STRIDE, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    IsRowMajor = gl.Constants.GL_IS_ROW_MAJOR, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    AtomicCounterBufferIndex = gl.Constants.GL_ATOMIC_COUNTER_BUFFER_INDEX, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    BufferBinding = gl.Constants.GL_BUFFER_BINDING, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    BufferDataSize = gl.Constants.GL_BUFFER_DATA_SIZE, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    NumActiveVariables = gl.Constants.GL_NUM_ACTIVE_VARIABLES, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    ActiveVariables = gl.Constants.GL_ACTIVE_VARIABLES, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    ReferencedByVertexShader = gl.Constants.GL_REFERENCED_BY_VERTEX_SHADER, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    ReferencedByFragmentShader = gl.Constants.GL_REFERENCED_BY_FRAGMENT_SHADER, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    ReferencedByComputeShader = gl.Constants.GL_REFERENCED_BY_COMPUTE_SHADER, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    TopLevelArraySize = gl.Constants.GL_TOP_LEVEL_ARRAY_SIZE, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    TopLevelArrayStride = gl.Constants.GL_TOP_LEVEL_ARRAY_STRIDE, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    Location = gl.Constants.GL_LOCATION, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_2 || GL_VERSION_4_3)
    IsPerPatch = gl.Constants.GL_IS_PER_PATCH, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_2 || GL_VERSION_4_3)
    ReferencedByTessControlShader = gl.Constants.GL_REFERENCED_BY_TESS_CONTROL_SHADER, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_2 || GL_VERSION_4_3)
    ReferencedByTessEvaluationShader = gl.Constants.GL_REFERENCED_BY_TESS_EVALUATION_SHADER, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_2 || GL_VERSION_4_3)
    ReferencedByGeometryShader = gl.Constants.GL_REFERENCED_BY_GEOMETRY_SHADER, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ARB_SHADER_SUBROUTINE || GL_VERSION_4_0)
    NumCompatibleSubroutines = gl.Constants.GL_NUM_COMPATIBLE_SUBROUTINES, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ARB_SHADER_SUBROUTINE || GL_VERSION_4_0)
    CompatibleSubroutines = gl.Constants.GL_COMPATIBLE_SUBROUTINES, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_VERSION_4_3)
    LocationIndex = gl.Constants.GL_LOCATION_INDEX, 
#endif

#if (GL_ARB_ENHANCED_LAYOUTS || GL_VERSION_4_4)
    LocationComponent = gl.Constants.GL_LOCATION_COMPONENT, 
#endif

#if (GL_ARB_ENHANCED_LAYOUTS || GL_VERSION_4_4)
    TransformFeedbackBufferIndex = gl.Constants.GL_TRANSFORM_FEEDBACK_BUFFER_INDEX, 
#endif

#if (GL_ARB_ENHANCED_LAYOUTS || GL_VERSION_4_4)
    TransformFeedbackBufferStride = gl.Constants.GL_TRANSFORM_FEEDBACK_BUFFER_STRIDE, 
#endif

}

#endif
