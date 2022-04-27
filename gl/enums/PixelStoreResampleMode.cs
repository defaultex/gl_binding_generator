#if GL_SGIX_RESAMPLE

public enum PixelStoreResampleMode : GLenum { 
#if GL_SGIX_RESAMPLE
    ResampleDecimateSgix = gl.Constants.GL_RESAMPLE_DECIMATE_SGIX, 
#endif

#if GL_SGIX_RESAMPLE
    ResampleReplicateSgix = gl.Constants.GL_RESAMPLE_REPLICATE_SGIX, 
#endif

#if GL_SGIX_RESAMPLE
    ResampleZeroFillSgix = gl.Constants.GL_RESAMPLE_ZERO_FILL_SGIX, 
#endif

}

#endif
