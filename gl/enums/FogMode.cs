#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0 || GL_SGIS_FOG_FUNCTION)

public enum FogMode : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Linear = gl.Constants.GL_LINEAR, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Exp = gl.Constants.GL_EXP, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Exp2 = gl.Constants.GL_EXP2, 
#endif

#if GL_SGIS_FOG_FUNCTION
    FuncSgis = gl.Constants.GL_FOG_FUNC_SGIS, 
#endif

}

#endif
