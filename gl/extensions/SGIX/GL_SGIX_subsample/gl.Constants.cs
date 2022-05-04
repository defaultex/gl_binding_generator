#if (GL_SGIX_subsample && GL_API)
public partial class sgix { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PACK_SUBSAMPLE_RATE_SGIX = 0x85A0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNPACK_SUBSAMPLE_RATE_SGIX = 0x85A1;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_SUBSAMPLE_4444_SGIX = 0x85A2;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_SUBSAMPLE_2424_SGIX = 0x85A3;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_SUBSAMPLE_4242_SGIX = 0x85A4;
#endif
    }
}
#endif