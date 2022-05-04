#if (GL_EXT_texture_compression_latc && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_LUMINANCE_LATC1_EXT = 0x8C70;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_SIGNED_LUMINANCE_LATC1_EXT = 0x8C71;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_LUMINANCE_ALPHA_LATC2_EXT = 0x8C72;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_SIGNED_LUMINANCE_ALPHA_LATC2_EXT = 0x8C73;
#endif
    }
}
#endif