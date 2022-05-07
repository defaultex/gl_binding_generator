#if (GL_EXT_framebuffer_sRGB && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_FRAMEBUFFER_SRGB_EXT = 0x8DB9;
        public const GLenum GL_FRAMEBUFFER_SRGB_CAPABLE_EXT = 0x8DBA;
    }
}
#endif