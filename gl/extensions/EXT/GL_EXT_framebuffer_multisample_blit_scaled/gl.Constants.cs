#if (GL_EXT_framebuffer_multisample_blit_scaled && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SCALED_RESOLVE_FASTEST_EXT = 0x90BA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SCALED_RESOLVE_NICEST_EXT = 0x90BB;
#endif
    }
}
#endif