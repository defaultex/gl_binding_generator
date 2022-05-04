#if (GL_NV_fragment_program && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_FRAGMENT_PROGRAM_LOCAL_PARAMETERS_NV = 0x8868;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAGMENT_PROGRAM_NV = 0x8870;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TEXTURE_COORDS_NV = 0x8871;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TEXTURE_IMAGE_UNITS_NV = 0x8872;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAGMENT_PROGRAM_BINDING_NV = 0x8873;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PROGRAM_ERROR_STRING_NV = 0x8874;
#endif
    }
}
#endif