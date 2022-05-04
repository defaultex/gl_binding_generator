#if (GL_NV_conservative_raster && (GL_API || GLCORE_API || GLES2_API))
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONSERVATIVE_RASTERIZATION_NV = 0x9346;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SUBPIXEL_PRECISION_BIAS_X_BITS_NV = 0x9347;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SUBPIXEL_PRECISION_BIAS_Y_BITS_NV = 0x9348;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_SUBPIXEL_PRECISION_BIAS_BITS_NV = 0x9349;
#endif
    }
}
#endif