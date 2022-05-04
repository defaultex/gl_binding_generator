#if (GL_IMG_texture_compression_pvrtc2 && GLES2_API)
public partial class img { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_RGBA_PVRTC_2BPPV2_IMG = 0x9137;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_RGBA_PVRTC_4BPPV2_IMG = 0x9138;
#endif
    }
}
#endif