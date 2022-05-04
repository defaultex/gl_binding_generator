#if (GL_ARB_texture_compression && GL_API)
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_ALPHA_ARB = 0x84E9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_LUMINANCE_ARB = 0x84EA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_LUMINANCE_ALPHA_ARB = 0x84EB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_INTENSITY_ARB = 0x84EC;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_RGB_ARB = 0x84ED;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_RGBA_ARB = 0x84EE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_COMPRESSION_HINT_ARB = 0x84EF;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_COMPRESSED_IMAGE_SIZE_ARB = 0x86A0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_COMPRESSED_ARB = 0x86A1;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_NUM_COMPRESSED_TEXTURE_FORMATS_ARB = 0x86A2;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_TEXTURE_FORMATS_ARB = 0x86A3;
#endif
    }
}
#endif