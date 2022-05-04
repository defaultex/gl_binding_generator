#if (GL_NV_transform_feedback2 && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TRANSFORM_FEEDBACK_NV = 0x8E22;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED_NV = 0x8E23;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE_NV = 0x8E24;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TRANSFORM_FEEDBACK_BINDING_NV = 0x8E25;
#endif
    }
}
#endif