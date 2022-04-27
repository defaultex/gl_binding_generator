#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_ARB_GET_PROGRAM_BINARY || GL_ES_VERSION_3_0 || GL_VERSION_4_1 || GL_ARB_UNIFORM_BUFFER_OBJECT || GL_VERSION_3_1 || GL_VERSION_3_0 || GL_ARB_COMPUTE_SHADER || GL_ES_VERSION_3_1 || GL_VERSION_4_3 || GL_ARB_SHADER_ATOMIC_COUNTERS || GL_VERSION_4_2 || GL_ES_VERSION_3_2 || GL_VERSION_3_2)

public enum ProgramPropertyARB : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0)
    DeleteStatus = gl.Constants.GL_DELETE_STATUS, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_2_0)
    LinkStatus = gl.Constants.GL_LINK_STATUS, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0)
    ValidateStatus = gl.Constants.GL_VALIDATE_STATUS, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0)
    InfoLogLength = gl.Constants.GL_INFO_LOG_LENGTH, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0)
    AttachedShaders = gl.Constants.GL_ATTACHED_SHADERS, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0)
    ActiveUniforms = gl.Constants.GL_ACTIVE_UNIFORMS, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0)
    ActiveUniformMaxLength = gl.Constants.GL_ACTIVE_UNIFORM_MAX_LENGTH, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0)
    ActiveAttributes = gl.Constants.GL_ACTIVE_ATTRIBUTES, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0)
    ActiveAttributeMaxLength = gl.Constants.GL_ACTIVE_ATTRIBUTE_MAX_LENGTH, 
#endif

#if (GL_ARB_GET_PROGRAM_BINARY || GL_ES_VERSION_3_0 || GL_VERSION_4_1)
    BinaryLength = gl.Constants.GL_PROGRAM_BINARY_LENGTH, 
#endif

#if (GL_ARB_UNIFORM_BUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_1)
    ActiveUniformBlockMaxNameLength = gl.Constants.GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH, 
#endif

#if (GL_ARB_UNIFORM_BUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_1)
    ActiveUniformBlocks = gl.Constants.GL_ACTIVE_UNIFORM_BLOCKS, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    TransformFeedbackVaryingMaxLength = gl.Constants.GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    TransformFeedbackBufferMode = gl.Constants.GL_TRANSFORM_FEEDBACK_BUFFER_MODE, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    TransformFeedbackVaryings = gl.Constants.GL_TRANSFORM_FEEDBACK_VARYINGS, 
#endif

#if (GL_ARB_COMPUTE_SHADER || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    ComputeWorkGroupSize = gl.Constants.GL_COMPUTE_WORK_GROUP_SIZE, 
#endif

#if (GL_ARB_SHADER_ATOMIC_COUNTERS || GL_ES_VERSION_3_1 || GL_VERSION_4_2)
    ActiveAtomicCounterBuffers = gl.Constants.GL_ACTIVE_ATOMIC_COUNTER_BUFFERS, 
#endif

#if (GL_ES_VERSION_3_2 || GL_VERSION_3_2)
    GeometryVerticesOut = gl.Constants.GL_GEOMETRY_VERTICES_OUT, 
#endif

#if (GL_ES_VERSION_3_2 || GL_VERSION_3_2)
    GeometryInputType = gl.Constants.GL_GEOMETRY_INPUT_TYPE, 
#endif

#if (GL_ES_VERSION_3_2 || GL_VERSION_3_2)
    GeometryOutputType = gl.Constants.GL_GEOMETRY_OUTPUT_TYPE, 
#endif

}

#endif
