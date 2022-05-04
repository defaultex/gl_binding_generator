#if (GL_OES_texture_view && GLES2_API)
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_VIEW_MIN_LEVEL_OES = 0x82DB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_VIEW_NUM_LEVELS_OES = 0x82DC;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_VIEW_MIN_LAYER_OES = 0x82DD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_VIEW_NUM_LAYERS_OES = 0x82DE;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_IMMUTABLE_LEVELS = 0x82DF;
#endif
    }
}
#endif