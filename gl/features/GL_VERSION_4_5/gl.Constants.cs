#if (GL_VERSION_4_5 && GL_API)
public partial class gl { 
    public partial class Constants { 
        public const GLbitfield GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT = 0x00000004;
        public const GLenum GL_CONTEXT_LOST = 0x0507;
        public const GLenum GL_TEXTURE_TARGET = 0x1006;
        public const GLenum GL_CONVOLUTION_1D = 0x8010;
        public const GLenum GL_CONVOLUTION_2D = 0x8011;
        public const GLenum GL_SEPARABLE_2D = 0x8012;
        public const GLenum GL_HISTOGRAM = 0x8024;
        public const GLenum GL_PROXY_HISTOGRAM = 0x8025;
        public const GLenum GL_MINMAX = 0x802E;
        public const GLenum GL_COLOR_TABLE = 0x80D0;
        public const GLenum GL_POST_CONVOLUTION_COLOR_TABLE = 0x80D1;
        public const GLenum GL_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D2;
        public const GLenum GL_PROXY_COLOR_TABLE = 0x80D3;
        public const GLenum GL_PROXY_POST_CONVOLUTION_COLOR_TABLE = 0x80D4;
        public const GLenum GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D5;
        public const GLenum GL_LOSE_CONTEXT_ON_RESET = 0x8252;
        public const GLenum GL_GUILTY_CONTEXT_RESET = 0x8253;
        public const GLenum GL_INNOCENT_CONTEXT_RESET = 0x8254;
        public const GLenum GL_UNKNOWN_CONTEXT_RESET = 0x8255;
        public const GLenum GL_RESET_NOTIFICATION_STRATEGY = 0x8256;
        public const GLenum GL_NO_RESET_NOTIFICATION = 0x8261;
        public const GLenum GL_QUERY_TARGET = 0x82EA;
        public const GLenum GL_MAX_CULL_DISTANCES = 0x82F9;
        public const GLenum GL_MAX_COMBINED_CLIP_AND_CULL_DISTANCES = 0x82FA;
        public const GLenum GL_CONTEXT_RELEASE_BEHAVIOR = 0x82FB;
        public const GLenum GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH = 0x82FC;
        public const GLenum GL_QUERY_WAIT_INVERTED = 0x8E17;
        public const GLenum GL_QUERY_NO_WAIT_INVERTED = 0x8E18;
        public const GLenum GL_QUERY_BY_REGION_WAIT_INVERTED = 0x8E19;
        public const GLenum GL_QUERY_BY_REGION_NO_WAIT_INVERTED = 0x8E1A;
        public const GLenum GL_CLIP_ORIGIN = 0x935C;
        public const GLenum GL_CLIP_DEPTH_MODE = 0x935D;
        public const GLenum GL_NEGATIVE_ONE_TO_ONE = 0x935E;
        public const GLenum GL_ZERO_TO_ONE = 0x935F;
    }
}
#endif