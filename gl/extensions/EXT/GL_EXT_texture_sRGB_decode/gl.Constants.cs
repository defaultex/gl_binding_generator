#if (GL_EXT_texture_sRGB_decode && (GL_API || GLCORE_API || GLES2_API))
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_SRGB_DECODE_EXT = 0x8A48;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DECODE_EXT = 0x8A49;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SKIP_DECODE_EXT = 0x8A4A;
#endif
    }
}
#endif