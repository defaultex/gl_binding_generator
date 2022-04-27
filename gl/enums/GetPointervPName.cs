#if (GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_VERSION_4_3 || GL_VERSION_1_1 || GL_VERSION_ES_CM_1_0 || GL_EXT_VERTEX_ARRAY || GL_SGIX_INSTRUMENTS)

public enum GetPointervPName : GLenum { 
#if (GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_VERSION_4_3)
    DebugCallbackFunction = gl.Constants.GL_DEBUG_CALLBACK_FUNCTION, 
#endif

#if (GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_VERSION_4_3)
    DebugCallbackUserParam = gl.Constants.GL_DEBUG_CALLBACK_USER_PARAM, 
#endif

#if GL_VERSION_1_1
    FeedbackBufferPointer = gl.Constants.GL_FEEDBACK_BUFFER_POINTER, 
#endif

#if GL_VERSION_1_1
    SelectionBufferPointer = gl.Constants.GL_SELECTION_BUFFER_POINTER, 
#endif

#if (GL_VERSION_1_1 || GL_VERSION_ES_CM_1_0)
    VertexArrayPointer = gl.Constants.GL_VERTEX_ARRAY_POINTER, 
#endif

#if (GL_VERSION_1_1 || GL_VERSION_ES_CM_1_0)
    NormalArrayPointer = gl.Constants.GL_NORMAL_ARRAY_POINTER, 
#endif

#if (GL_VERSION_1_1 || GL_VERSION_ES_CM_1_0)
    ColorArrayPointer = gl.Constants.GL_COLOR_ARRAY_POINTER, 
#endif

#if GL_VERSION_1_1
    IndexArrayPointer = gl.Constants.GL_INDEX_ARRAY_POINTER, 
#endif

#if (GL_VERSION_1_1 || GL_VERSION_ES_CM_1_0)
    TextureCoordArrayPointer = gl.Constants.GL_TEXTURE_COORD_ARRAY_POINTER, 
#endif

#if GL_VERSION_1_1
    EdgeFlagArrayPointer = gl.Constants.GL_EDGE_FLAG_ARRAY_POINTER, 
#endif

#if GL_EXT_VERTEX_ARRAY
    VertexArrayPointerExt = gl.Constants.GL_VERTEX_ARRAY_POINTER_EXT, 
#endif

#if GL_EXT_VERTEX_ARRAY
    NormalArrayPointerExt = gl.Constants.GL_NORMAL_ARRAY_POINTER_EXT, 
#endif

#if GL_EXT_VERTEX_ARRAY
    ColorArrayPointerExt = gl.Constants.GL_COLOR_ARRAY_POINTER_EXT, 
#endif

#if GL_EXT_VERTEX_ARRAY
    IndexArrayPointerExt = gl.Constants.GL_INDEX_ARRAY_POINTER_EXT, 
#endif

#if GL_EXT_VERTEX_ARRAY
    TextureCoordArrayPointerExt = gl.Constants.GL_TEXTURE_COORD_ARRAY_POINTER_EXT, 
#endif

#if GL_EXT_VERTEX_ARRAY
    EdgeFlagArrayPointerExt = gl.Constants.GL_EDGE_FLAG_ARRAY_POINTER_EXT, 
#endif

#if GL_SGIX_INSTRUMENTS
    InstrumentBufferPointerSgix = gl.Constants.GL_INSTRUMENT_BUFFER_POINTER_SGIX, 
#endif

}

#endif
