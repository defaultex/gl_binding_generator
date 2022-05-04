#if (GL_KHR_context_flush_control && (GL_API || GLCORE_API || GLES2_API))
public partial class khr { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_NONE = 0;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_CONTEXT_RELEASE_BEHAVIOR = 0x82FB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONTEXT_RELEASE_BEHAVIOR_KHR = 0x82FB;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH = 0x82FC;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH_KHR = 0x82FC;
#endif
    }
}
#endif