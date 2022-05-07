#if (GL_APPLE_framebuffer_multisample && (!gles1 || !gles2))
public partial class gles1 { 
    public partial class Constants { 
        public const GLenum GL_DRAW_FRAMEBUFFER_BINDING_APPLE = 0x8CA6;
        public const GLenum GL_READ_FRAMEBUFFER_APPLE = 0x8CA8;
        public const GLenum GL_DRAW_FRAMEBUFFER_APPLE = 0x8CA9;
        public const GLenum GL_READ_FRAMEBUFFER_BINDING_APPLE = 0x8CAA;
        public const GLenum GL_RENDERBUFFER_SAMPLES_APPLE = 0x8CAB;
        public const GLenum GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_APPLE = 0x8D56;
        public const GLenum GL_MAX_SAMPLES_APPLE = 0x8D57;
    }
}
#endif