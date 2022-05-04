#if (GL_ARB_fragment_shader && GL_API)
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAGMENT_SHADER_ARB = 0x8B30;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_FRAGMENT_UNIFORM_COMPONENTS_ARB = 0x8B49;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAGMENT_SHADER_DERIVATIVE_HINT_ARB = 0x8B8B;
#endif
    }
}
#endif