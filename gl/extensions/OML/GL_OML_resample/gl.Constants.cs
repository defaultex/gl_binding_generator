#if (GL_OML_resample && GL_API)
public partial class oml { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PACK_RESAMPLE_OML = 0x8984;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNPACK_RESAMPLE_OML = 0x8985;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RESAMPLE_REPLICATE_OML = 0x8986;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RESAMPLE_ZERO_FILL_OML = 0x8987;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RESAMPLE_AVERAGE_OML = 0x8988;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RESAMPLE_DECIMATE_OML = 0x8989;
#endif
    }
}
#endif