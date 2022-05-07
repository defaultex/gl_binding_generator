#if (GL_EXT_framebuffer_multisample_blit_scaled && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_SCALED_RESOLVE_FASTEST_EXT = 0x90BA;
        public const GLenum GL_SCALED_RESOLVE_NICEST_EXT = 0x90BB;
    }
}
#endif