#if (GL_KHR_context_flush_control && (GL_API || GLCORE_API || GLES2_API))
public partial class glext_khr { 
    public partial class Constants { 
        public const GLenum GL_NONE = 0;
        public const GLenum GL_CONTEXT_RELEASE_BEHAVIOR = 0x82FB;
        public const GLenum GL_CONTEXT_RELEASE_BEHAVIOR_KHR = 0x82FB;
        public const GLenum GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH = 0x82FC;
        public const GLenum GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH_KHR = 0x82FC;
    }
}
#endif