#if (GL_ARB_robustness && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_NO_ERROR = 0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB = 0x00000004;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LOSE_CONTEXT_ON_RESET_ARB = 0x8252;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_GUILTY_CONTEXT_RESET_ARB = 0x8253;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INNOCENT_CONTEXT_RESET_ARB = 0x8254;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNKNOWN_CONTEXT_RESET_ARB = 0x8255;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RESET_NOTIFICATION_STRATEGY_ARB = 0x8256;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_NO_RESET_NOTIFICATION_ARB = 0x8261;
#endif
    }
}
#endif