#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0 || GL_VERSION_1_5)

public enum FogPName : GLenum { 
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

#if GL_VERSION_1_5
    CoordSrc = gl.Constants.GL_FOG_COORD_SRC, 
#endif

}

#endif
