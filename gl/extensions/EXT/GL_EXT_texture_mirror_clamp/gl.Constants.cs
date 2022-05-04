#if (GL_EXT_texture_mirror_clamp && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MIRROR_CLAMP_EXT = 0x8742;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MIRROR_CLAMP_TO_EDGE_EXT = 0x8743;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MIRROR_CLAMP_TO_BORDER_EXT = 0x8912;
#endif
    }
}
#endif