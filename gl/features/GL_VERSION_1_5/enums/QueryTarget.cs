public enum QueryTarget : GLenum {
    SamplesPassed = gl.Constants.GL_SAMPLES_PASSED,
    PrimitivesGenerated = gl.Constants.GL_PRIMITIVES_GENERATED,
    TransformFeedbackPrimitivesWritten = gl.Constants.GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN,
    AnySamplesPassed = gl.Constants.GL_ANY_SAMPLES_PASSED,
    TimeElapsed = gl.Constants.GL_TIME_ELAPSED,
    AnySamplesPassedConservative = gl.Constants.GL_ANY_SAMPLES_PASSED_CONSERVATIVE,
    VerticesSubmitted = gl.Constants.GL_VERTICES_SUBMITTED,
    PrimitivesSubmitted = gl.Constants.GL_PRIMITIVES_SUBMITTED,
    VertexShaderInvocations = gl.Constants.GL_VERTEX_SHADER_INVOCATIONS,
    TransformFeedbackOverflow = gl.Constants.GL_TRANSFORM_FEEDBACK_OVERFLOW,
}
