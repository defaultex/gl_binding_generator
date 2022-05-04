#if (GL_ARB_compute_variable_group_size && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_COMPUTE_FIXED_GROUP_INVOCATIONS_ARB = 0x90EB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_COMPUTE_FIXED_GROUP_SIZE_ARB = 0x91BF;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_COMPUTE_VARIABLE_GROUP_INVOCATIONS_ARB = 0x9344;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_COMPUTE_VARIABLE_GROUP_SIZE_ARB = 0x9345;
#endif
    }
}
#endif