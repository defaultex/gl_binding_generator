#if (GL_ARB_OCCLUSION_QUERY2 || GL_ES_VERSION_3_0 || GL_VERSION_3_3 || GL_VERSION_3_0 || GL_ARB_ES3_COMPATIBILITY || GL_VERSION_4_3 || GL_ES_VERSION_3_2 || GL_VERSION_1_5 || GL_ARB_TIMER_QUERY || GL_VERSION_4_6)

public enum QueryTarget : GLenum { 
#if (GL_ARB_OCCLUSION_QUERY2 || GL_ES_VERSION_3_0 || GL_VERSION_3_3)
    AnySamplesPassed = gl.Constants.GL_ANY_SAMPLES_PASSED, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    TransformFeedbackPrimitivesWritten = gl.Constants.GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, 
#endif

#if (GL_ARB_ES3_COMPATIBILITY || GL_ES_VERSION_3_0 || GL_VERSION_4_3)
    AnySamplesPassedConservative = gl.Constants.GL_ANY_SAMPLES_PASSED_CONSERVATIVE, 
#endif

#if (GL_ES_VERSION_3_2 || GL_VERSION_3_0)
    PrimitivesGenerated = gl.Constants.GL_PRIMITIVES_GENERATED, 
#endif

#if GL_VERSION_1_5
    SamplesPassed = gl.Constants.GL_SAMPLES_PASSED, 
#endif

#if (GL_ARB_TIMER_QUERY || GL_VERSION_3_3)
    TimeElapsed = gl.Constants.GL_TIME_ELAPSED, 
#endif

#if GL_VERSION_4_6
    TransformFeedbackOverflow = gl.Constants.GL_TRANSFORM_FEEDBACK_OVERFLOW, 
#endif

#if GL_VERSION_4_6
    VerticesSubmitted = gl.Constants.GL_VERTICES_SUBMITTED, 
#endif

#if GL_VERSION_4_6
    PrimitivesSubmitted = gl.Constants.GL_PRIMITIVES_SUBMITTED, 
#endif

#if GL_VERSION_4_6
    VertexShaderInvocations = gl.Constants.GL_VERTEX_SHADER_INVOCATIONS, 
#endif

}

#endif
