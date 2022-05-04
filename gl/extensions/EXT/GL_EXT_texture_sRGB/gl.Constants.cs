#if (GL_EXT_texture_sRGB && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SRGB_EXT = 0x8C40;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SRGB8_EXT = 0x8C41;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SRGB_ALPHA_EXT = 0x8C42;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SRGB8_ALPHA8_EXT = 0x8C43;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SLUMINANCE_ALPHA_EXT = 0x8C44;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SLUMINANCE8_ALPHA8_EXT = 0x8C45;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SLUMINANCE_EXT = 0x8C46;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SLUMINANCE8_EXT = 0x8C47;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_SRGB_EXT = 0x8C48;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_SRGB_ALPHA_EXT = 0x8C49;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_SLUMINANCE_EXT = 0x8C4A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_SLUMINANCE_ALPHA_EXT = 0x8C4B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_SRGB_S3TC_DXT1_EXT = 0x8C4C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT = 0x8C4D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT = 0x8C4E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT = 0x8C4F;
#endif
    }
}
#endif