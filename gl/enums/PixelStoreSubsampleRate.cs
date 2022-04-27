#if GL_SGIX_SUBSAMPLE

public enum PixelStoreSubsampleRate : GLenum { 
#if GL_SGIX_SUBSAMPLE
    Subsample4444Sgix = gl.Constants.GL_PIXEL_SUBSAMPLE_4444_SGIX, 
#endif

#if GL_SGIX_SUBSAMPLE
    Subsample2424Sgix = gl.Constants.GL_PIXEL_SUBSAMPLE_2424_SGIX, 
#endif

#if GL_SGIX_SUBSAMPLE
    Subsample4242Sgix = gl.Constants.GL_PIXEL_SUBSAMPLE_4242_SGIX, 
#endif

}

#endif
