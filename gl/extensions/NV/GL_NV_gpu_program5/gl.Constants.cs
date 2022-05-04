#if (GL_NV_gpu_program5 && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_GEOMETRY_PROGRAM_INVOCATIONS_NV = 0x8E5A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MIN_FRAGMENT_INTERPOLATION_OFFSET_NV = 0x8E5B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_FRAGMENT_INTERPOLATION_OFFSET_NV = 0x8E5C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAGMENT_PROGRAM_INTERPOLATION_OFFSET_BITS_NV = 0x8E5D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET_NV = 0x8E5E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET_NV = 0x8E5F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_PROGRAM_SUBROUTINE_PARAMETERS_NV = 0x8F44;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_PROGRAM_SUBROUTINE_NUM_NV = 0x8F45;
#endif
    }
}
#endif