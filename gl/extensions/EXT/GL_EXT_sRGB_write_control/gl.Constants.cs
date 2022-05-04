#if (GL_EXT_sRGB_write_control && GLES2_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAMEBUFFER_SRGB_EXT = 0x8DB9;
#endif
    }
}
#endif