#if (GL_MESA_framebuffer_flip_y && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_FRAMEBUFFER_FLIP_Y_MESA = 0x8BBB;
    }
}
#endif