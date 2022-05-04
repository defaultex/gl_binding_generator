#if (GL_NV_tessellation_program5 && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_PROGRAM_PATCH_ATTRIBS_NV = 0x86D8;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TESS_CONTROL_PROGRAM_NV = 0x891E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TESS_EVALUATION_PROGRAM_NV = 0x891F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TESS_CONTROL_PROGRAM_PARAMETER_BUFFER_NV = 0x8C74;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TESS_EVALUATION_PROGRAM_PARAMETER_BUFFER_NV = 0x8C75;
#endif
    }
}
#endif