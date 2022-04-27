#if (GL_MESA_framebuffer_flip_y && (GL_API || GLCORE_API || GLES2_API))
public partial class glext_mesa { 
    public partial class Constants { 
        public const GLenum GL_FRAMEBUFFER_FLIP_Y_MESA = 0x8BBB;
    }
}
#endif