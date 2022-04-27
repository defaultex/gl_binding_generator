#if GL_SGIX_FRAGMENT_LIGHTING

public enum FragmentLightModelParameterSGIX : GLenum { 
#if GL_SGIX_FRAGMENT_LIGHTING
    LocalViewerSgix = gl.Constants.GL_FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX, 
#endif

#if GL_SGIX_FRAGMENT_LIGHTING
    TwoSideSgix = gl.Constants.GL_FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX, 
#endif

#if GL_SGIX_FRAGMENT_LIGHTING
    AmbientSgix = gl.Constants.GL_FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX, 
#endif

#if GL_SGIX_FRAGMENT_LIGHTING
    NormalInterpolationSgix = gl.Constants.GL_FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX, 
#endif

}

#endif
