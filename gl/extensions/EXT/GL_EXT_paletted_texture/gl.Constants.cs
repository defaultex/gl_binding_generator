#if (GL_EXT_paletted_texture && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_INDEX1_EXT = 0x80E2;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_INDEX2_EXT = 0x80E3;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_INDEX4_EXT = 0x80E4;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_INDEX8_EXT = 0x80E5;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_INDEX12_EXT = 0x80E6;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_INDEX16_EXT = 0x80E7;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_INDEX_SIZE_EXT = 0x80ED;
#endif
    }
}
#endif