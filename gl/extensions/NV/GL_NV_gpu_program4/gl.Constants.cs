#if (GL_NV_gpu_program4 && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MIN_PROGRAM_TEXEL_OFFSET_NV = 0x8904;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_PROGRAM_TEXEL_OFFSET_NV = 0x8905;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PROGRAM_ATTRIB_COMPONENTS_NV = 0x8906;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PROGRAM_RESULT_COMPONENTS_NV = 0x8907;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_PROGRAM_ATTRIB_COMPONENTS_NV = 0x8908;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_PROGRAM_RESULT_COMPONENTS_NV = 0x8909;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_PROGRAM_GENERIC_ATTRIBS_NV = 0x8DA5;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_PROGRAM_GENERIC_RESULTS_NV = 0x8DA6;
#endif
    }
}
#endif