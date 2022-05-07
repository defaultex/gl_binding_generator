#if (GL_EXT_texture_view && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_VIEW_MIN_LEVEL_EXT = 0x82DB;
        public const GLenum GL_TEXTURE_VIEW_NUM_LEVELS_EXT = 0x82DC;
        public const GLenum GL_TEXTURE_VIEW_MIN_LAYER_EXT = 0x82DD;
        public const GLenum GL_TEXTURE_VIEW_NUM_LAYERS_EXT = 0x82DE;
        public const GLenum GL_TEXTURE_IMMUTABLE_LEVELS = 0x82DF;
    }
}
#endif