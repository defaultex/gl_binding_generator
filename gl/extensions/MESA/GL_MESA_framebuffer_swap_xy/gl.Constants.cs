#if (GL_MESA_framebuffer_swap_xy && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_FRAMEBUFFER_SWAP_XY_MESA = 0x8BBD;
    }
}
#endif