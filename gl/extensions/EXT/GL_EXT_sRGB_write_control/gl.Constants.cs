#if (GL_EXT_sRGB_write_control && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_FRAMEBUFFER_SRGB_EXT = 0x8DB9;
    }
}
#endif