#if (GL_NV_sRGB_formats && GLES2_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ETC1_SRGB8_NV = 0x88EE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SRGB8_NV = 0x8C41;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SLUMINANCE_ALPHA_NV = 0x8C44;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SLUMINANCE8_ALPHA8_NV = 0x8C45;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SLUMINANCE_NV = 0x8C46;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SLUMINANCE8_NV = 0x8C47;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_SRGB_S3TC_DXT1_NV = 0x8C4C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_NV = 0x8C4D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_NV = 0x8C4E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_NV = 0x8C4F;
#endif
    }
}
#endif