#if (GL_SGIX_resample && GL_API)
public partial class sgix { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PACK_RESAMPLE_SGIX = 0x842E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNPACK_RESAMPLE_SGIX = 0x842F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RESAMPLE_DECIMATE_SGIX = 0x8430;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RESAMPLE_REPLICATE_SGIX = 0x8433;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RESAMPLE_ZERO_FILL_SGIX = 0x8434;
#endif
    }
}
#endif