#if (GL_ARB_texture_view && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_VIEW_MIN_LEVEL = 0x82DB;
        public const GLenum GL_TEXTURE_VIEW_NUM_LEVELS = 0x82DC;
        public const GLenum GL_TEXTURE_VIEW_MIN_LAYER = 0x82DD;
        public const GLenum GL_TEXTURE_VIEW_NUM_LAYERS = 0x82DE;
        public const GLenum GL_TEXTURE_IMMUTABLE_LEVELS = 0x82DF;
    }
}
#endif