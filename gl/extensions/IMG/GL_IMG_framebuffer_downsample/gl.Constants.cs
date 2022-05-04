#if (GL_IMG_framebuffer_downsample && GLES2_API)
public partial class img { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_AND_DOWNSAMPLE_IMG = 0x913C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_NUM_DOWNSAMPLE_SCALES_IMG = 0x913D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DOWNSAMPLE_SCALES_IMG = 0x913E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SCALE_IMG = 0x913F;
#endif
    }
}
#endif