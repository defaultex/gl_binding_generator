#if (GL_KHR_robustness && (GL_API || GLCORE_API || GLES2_API))
public partial class khr { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_NO_ERROR = 0;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_CONTEXT_LOST = 0x0507;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONTEXT_LOST_KHR = 0x0507;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_LOSE_CONTEXT_ON_RESET = 0x8252;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LOSE_CONTEXT_ON_RESET_KHR = 0x8252;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_GUILTY_CONTEXT_RESET = 0x8253;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_GUILTY_CONTEXT_RESET_KHR = 0x8253;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_INNOCENT_CONTEXT_RESET = 0x8254;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INNOCENT_CONTEXT_RESET_KHR = 0x8254;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_UNKNOWN_CONTEXT_RESET = 0x8255;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNKNOWN_CONTEXT_RESET_KHR = 0x8255;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_RESET_NOTIFICATION_STRATEGY = 0x8256;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RESET_NOTIFICATION_STRATEGY_KHR = 0x8256;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_NO_RESET_NOTIFICATION = 0x8261;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_NO_RESET_NOTIFICATION_KHR = 0x8261;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_CONTEXT_ROBUST_ACCESS = 0x90F3;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONTEXT_ROBUST_ACCESS_KHR = 0x90F3;
#endif
    }
}
#endif