#if (GL_EXT_blend_func_extended && GLES2_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SRC_ALPHA_SATURATE_EXT = 0x0308;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SRC1_ALPHA_EXT = 0x8589;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SRC1_COLOR_EXT = 0x88F9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ONE_MINUS_SRC1_COLOR_EXT = 0x88FA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ONE_MINUS_SRC1_ALPHA_EXT = 0x88FB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_DUAL_SOURCE_DRAW_BUFFERS_EXT = 0x88FC;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LOCATION_INDEX_EXT = 0x930F;
#endif
    }
}
#endif