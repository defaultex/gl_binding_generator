#if (GL_EXT_texture_compression_bptc && GLES2_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_RGBA_BPTC_UNORM_EXT = 0x8E8C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM_EXT = 0x8E8D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT_EXT = 0x8E8E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_EXT = 0x8E8F;
#endif
    }
}
#endif