#if (GL_SGIX_instruments && GL_API)
public partial class sgix { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INSTRUMENT_BUFFER_POINTER_SGIX = 0x8180;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INSTRUMENT_MEASUREMENTS_SGIX = 0x8181;
#endif
    }
}
#endif