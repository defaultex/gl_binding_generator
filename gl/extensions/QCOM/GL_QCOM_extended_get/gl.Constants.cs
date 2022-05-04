#if (GL_QCOM_extended_get && (GLES1_API || GLES2_API))
public partial class qcom { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_WIDTH_QCOM = 0x8BD2;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_HEIGHT_QCOM = 0x8BD3;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_DEPTH_QCOM = 0x8BD4;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_INTERNAL_FORMAT_QCOM = 0x8BD5;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_FORMAT_QCOM = 0x8BD6;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_TYPE_QCOM = 0x8BD7;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_IMAGE_VALID_QCOM = 0x8BD8;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_NUM_LEVELS_QCOM = 0x8BD9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_TARGET_QCOM = 0x8BDA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_OBJECT_VALID_QCOM = 0x8BDB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_STATE_RESTORE = 0x8BDC;
#endif
    }
}
#endif