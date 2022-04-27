#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)

public enum ColorMaterialParameter : GLenum { 
#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Ambient = gl.Constants.GL_AMBIENT, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Diffuse = gl.Constants.GL_DIFFUSE, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Specular = gl.Constants.GL_SPECULAR, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Emission = gl.Constants.GL_EMISSION, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    AmbientAndDiffuse = gl.Constants.GL_AMBIENT_AND_DIFFUSE, 
#endif

}

#endif
