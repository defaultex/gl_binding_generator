#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0 || GL_VERSION_3_0)

public enum ClipPlaneName : GLenum { 
#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Plane0 = gl.Constants.GL_CLIP_PLANE0, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Plane1 = gl.Constants.GL_CLIP_PLANE1, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Plane2 = gl.Constants.GL_CLIP_PLANE2, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Plane3 = gl.Constants.GL_CLIP_PLANE3, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Plane4 = gl.Constants.GL_CLIP_PLANE4, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Plane5 = gl.Constants.GL_CLIP_PLANE5, 
#endif

#if GL_VERSION_3_0
    Distance0 = gl.Constants.GL_CLIP_DISTANCE0, 
#endif

#if GL_VERSION_3_0
    Distance1 = gl.Constants.GL_CLIP_DISTANCE1, 
#endif

#if GL_VERSION_3_0
    Distance2 = gl.Constants.GL_CLIP_DISTANCE2, 
#endif

#if GL_VERSION_3_0
    Distance3 = gl.Constants.GL_CLIP_DISTANCE3, 
#endif

#if GL_VERSION_3_0
    Distance4 = gl.Constants.GL_CLIP_DISTANCE4, 
#endif

#if GL_VERSION_3_0
    Distance5 = gl.Constants.GL_CLIP_DISTANCE5, 
#endif

#if GL_VERSION_3_0
    Distance6 = gl.Constants.GL_CLIP_DISTANCE6, 
#endif

#if GL_VERSION_3_0
    Distance7 = gl.Constants.GL_CLIP_DISTANCE7, 
#endif

}

#endif
