[Flags]
public enum ContextFlagMask : GLbitfield {
    ContextFlagForwardCompatible = gl.Constants.GL_CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT,
    ContextFlagDebug = gl.Constants.GL_CONTEXT_FLAG_DEBUG_BIT,
    ContextFlagRobustAccess = gl.Constants.GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT,
    ContextFlagNoError = gl.Constants.GL_CONTEXT_FLAG_NO_ERROR_BIT,
#if GL_ARB_robustness
    ContextFlagRobustAccessBitArb = gl.Constants.GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB,
#endif

#if GL_KHR_no_error
    ContextFlagNoErrorBitKhr = gl.Constants.GL_CONTEXT_FLAG_NO_ERROR_BIT_KHR,
#endif
}
