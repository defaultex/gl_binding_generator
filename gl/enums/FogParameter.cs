#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0 || GL_SGIX_FOG_OFFSET)

public enum FogParameter : GLenum { 
#if GL_VERSION_1_0
    Index = gl.Constants.GL_FOG_INDEX, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Density = gl.Constants.GL_FOG_DENSITY, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Start = gl.Constants.GL_FOG_START, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    End = gl.Constants.GL_FOG_END, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Mode = gl.Constants.GL_FOG_MODE, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Color = gl.Constants.GL_FOG_COLOR, 
#endif

#if GL_SGIX_FOG_OFFSET
    OffsetValueSgix = gl.Constants.GL_FOG_OFFSET_VALUE_SGIX, 
#endif

}

#endif
