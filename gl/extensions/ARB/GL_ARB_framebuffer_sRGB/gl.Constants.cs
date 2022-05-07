#if (GL_ARB_framebuffer_sRGB && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_FRAMEBUFFER_SRGB = 0x8DB9;
    }
}
#endif