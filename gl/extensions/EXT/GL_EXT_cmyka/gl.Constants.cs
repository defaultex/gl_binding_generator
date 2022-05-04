#if (GL_EXT_cmyka && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CMYK_EXT = 0x800C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CMYKA_EXT = 0x800D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PACK_CMYK_HINT_EXT = 0x800E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNPACK_CMYK_HINT_EXT = 0x800F;
#endif
    }
}
#endif