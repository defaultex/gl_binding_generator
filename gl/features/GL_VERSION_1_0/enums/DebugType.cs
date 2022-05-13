public enum DebugType : GLenum {
    DontCare = gl.Constants.GL_DONT_CARE,
    DebugTypeError = gl.Constants.GL_DEBUG_TYPE_ERROR,
    DebugTypeDeprecatedBehavior = gl.Constants.GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR,
    DebugTypeUndefinedBehavior = gl.Constants.GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR,
    DebugTypePortability = gl.Constants.GL_DEBUG_TYPE_PORTABILITY,
    DebugTypePerformance = gl.Constants.GL_DEBUG_TYPE_PERFORMANCE,
    DebugTypeOther = gl.Constants.GL_DEBUG_TYPE_OTHER,
    DebugTypeMarker = gl.Constants.GL_DEBUG_TYPE_MARKER,
    DebugTypePushGroup = gl.Constants.GL_DEBUG_TYPE_PUSH_GROUP,
    DebugTypePopGroup = gl.Constants.GL_DEBUG_TYPE_POP_GROUP,
}
