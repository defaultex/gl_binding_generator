#if (GL_EXT_discard_framebuffer && (GLES1_API || GLES2_API))
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_EXT = 0x1800;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPTH_EXT = 0x1801;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_STENCIL_EXT = 0x1802;
#endif
    }
}
#endif