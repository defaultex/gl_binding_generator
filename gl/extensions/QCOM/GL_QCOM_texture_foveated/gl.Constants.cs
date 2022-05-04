#if (GL_QCOM_texture_foveated && GLES2_API)
public partial class qcom { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FOVEATION_ENABLE_BIT_QCOM = 0x00000001;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FOVEATION_SCALED_BIN_METHOD_BIT_QCOM = 0x00000002;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_FOVEATED_FEATURE_BITS_QCOM = 0x8BFB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_FOVEATED_MIN_PIXEL_DENSITY_QCOM = 0x8BFC;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_FOVEATED_FEATURE_QUERY_QCOM = 0x8BFD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_FOVEATED_NUM_FOCAL_POINTS_QUERY_QCOM = 0x8BFE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAMEBUFFER_INCOMPLETE_FOVEATION_QCOM = 0x8BFF;
#endif
    }
}
#endif