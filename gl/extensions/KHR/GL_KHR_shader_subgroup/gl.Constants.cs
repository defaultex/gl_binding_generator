#if (GL_KHR_shader_subgroup && (GL_API || GLCORE_API || GLES2_API))
public partial class khr { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SUBGROUP_FEATURE_BASIC_BIT_KHR = 0x00000001;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SUBGROUP_FEATURE_VOTE_BIT_KHR = 0x00000002;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SUBGROUP_FEATURE_ARITHMETIC_BIT_KHR = 0x00000004;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SUBGROUP_FEATURE_BALLOT_BIT_KHR = 0x00000008;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SUBGROUP_FEATURE_SHUFFLE_BIT_KHR = 0x00000010;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT_KHR = 0x00000020;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SUBGROUP_FEATURE_CLUSTERED_BIT_KHR = 0x00000040;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SUBGROUP_FEATURE_QUAD_BIT_KHR = 0x00000080;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SUBGROUP_SIZE_KHR = 0x9532;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SUBGROUP_SUPPORTED_STAGES_KHR = 0x9533;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SUBGROUP_SUPPORTED_FEATURES_KHR = 0x9534;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SUBGROUP_QUAD_ALL_STAGES_KHR = 0x9535;
#endif
    }
}
#endif