#if (GL_QCOM_shading_rate && GLES2_API)
public partial class qcom { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADING_RATE_QCOM = 0x96A4;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADING_RATE_PRESERVE_ASPECT_RATIO_QCOM = 0x96A5;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADING_RATE_1X1_PIXELS_QCOM = 0x96A6;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADING_RATE_1X2_PIXELS_QCOM = 0x96A7;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADING_RATE_2X1_PIXELS_QCOM = 0x96A8;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADING_RATE_2X2_PIXELS_QCOM = 0x96A9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADING_RATE_4X2_PIXELS_QCOM = 0x96AC;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADING_RATE_4X4_PIXELS_QCOM = 0x96AE;
#endif
    }
}
#endif