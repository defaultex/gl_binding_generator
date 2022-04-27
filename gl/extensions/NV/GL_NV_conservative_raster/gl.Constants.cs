#if (GL_NV_conservative_raster && (GL_API || GLCORE_API || GLES2_API))
public partial class glext_nv { 
    public partial class Constants { 
        public const GLenum GL_CONSERVATIVE_RASTERIZATION_NV = 0x9346;
        public const GLenum GL_SUBPIXEL_PRECISION_BIAS_X_BITS_NV = 0x9347;
        public const GLenum GL_SUBPIXEL_PRECISION_BIAS_Y_BITS_NV = 0x9348;
        public const GLenum GL_MAX_SUBPIXEL_PRECISION_BIAS_BITS_NV = 0x9349;
    }
}
#endif