#if (GL_ANGLE_framebuffer_blit && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_DRAW_FRAMEBUFFER_BINDING_ANGLE = 0x8CA6;
        public const GLenum GL_READ_FRAMEBUFFER_ANGLE = 0x8CA8;
        public const GLenum GL_DRAW_FRAMEBUFFER_ANGLE = 0x8CA9;
        public const GLenum GL_READ_FRAMEBUFFER_BINDING_ANGLE = 0x8CAA;
    }
}
#endif