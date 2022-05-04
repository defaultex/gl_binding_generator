#if (GL_OES_viewport_array && GLES2_API)
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEPTH_RANGE = 0x0B70;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_VIEWPORT = 0x0BA2;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_SCISSOR_BOX = 0x0C10;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_SCISSOR_TEST = 0x0C11;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_VIEWPORTS_OES = 0x825B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEWPORT_SUBPIXEL_BITS_OES = 0x825C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEWPORT_BOUNDS_RANGE_OES = 0x825D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEWPORT_INDEX_PROVOKING_VERTEX_OES = 0x825F;
#endif
    }
}
#endif