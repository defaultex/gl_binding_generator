#if (GL_ARB_transform_feedback2 && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TRANSFORM_FEEDBACK = 0x8E22;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED = 0x8E23;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE = 0x8E24;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TRANSFORM_FEEDBACK_BINDING = 0x8E25;
#endif
    }
}
#endif