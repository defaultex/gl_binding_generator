#if (GL_IMG_texture_compression_pvrtc && (GLES1_API || GLES2_API))
public partial class img { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_RGB_PVRTC_4BPPV1_IMG = 0x8C00;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_RGB_PVRTC_2BPPV1_IMG = 0x8C01;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_RGBA_PVRTC_4BPPV1_IMG = 0x8C02;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_RGBA_PVRTC_2BPPV1_IMG = 0x8C03;
#endif
    }
}
#endif