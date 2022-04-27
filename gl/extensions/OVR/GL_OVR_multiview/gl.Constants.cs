#if (GL_OVR_multiview && (GL_API || GLCORE_API || GLES2_API))
public partial class glext_ovr { 
    public partial class Constants { 
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_NUM_VIEWS_OVR = 0x9630;
        public const GLenum GL_MAX_VIEWS_OVR = 0x9631;
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_BASE_VIEW_INDEX_OVR = 0x9632;
        public const GLenum GL_FRAMEBUFFER_INCOMPLETE_VIEW_TARGETS_OVR = 0x9633;
    }
}
#endif