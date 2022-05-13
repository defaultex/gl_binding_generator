public enum GraphicsResetStatus : GLenum {
    NoError = gl.Constants.GL_NO_ERROR,
    GuiltyContextReset = gl.Constants.GL_GUILTY_CONTEXT_RESET,
    InnocentContextReset = gl.Constants.GL_INNOCENT_CONTEXT_RESET,
    UnknownContextReset = gl.Constants.GL_UNKNOWN_CONTEXT_RESET,
}
