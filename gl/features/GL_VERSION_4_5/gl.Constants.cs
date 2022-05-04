#if (GL_VERSION_4_5 && GL_API)
public partial class gl { 
    public partial class Constants { 

#if !GL_SC_VERSION_2_0
        public const GLbitfield GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT = 0x00000004;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_CONTEXT_LOST = 0x0507;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TEXTURE_TARGET = 0x1006;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_CONVOLUTION_1D = 0x8010;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_CONVOLUTION_2D = 0x8011;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_SEPARABLE_2D = 0x8012;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_HISTOGRAM = 0x8024;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_PROXY_HISTOGRAM = 0x8025;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MINMAX = 0x802E;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_COLOR_TABLE = 0x80D0;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_POST_CONVOLUTION_COLOR_TABLE = 0x80D1;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D2;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_PROXY_COLOR_TABLE = 0x80D3;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_PROXY_POST_CONVOLUTION_COLOR_TABLE = 0x80D4;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D5;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_LOSE_CONTEXT_ON_RESET = 0x8252;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_GUILTY_CONTEXT_RESET = 0x8253;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_INNOCENT_CONTEXT_RESET = 0x8254;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_UNKNOWN_CONTEXT_RESET = 0x8255;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_RESET_NOTIFICATION_STRATEGY = 0x8256;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_NO_RESET_NOTIFICATION = 0x8261;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_QUERY_TARGET = 0x82EA;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_CULL_DISTANCES = 0x82F9;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_COMBINED_CLIP_AND_CULL_DISTANCES = 0x82FA;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_CONTEXT_RELEASE_BEHAVIOR = 0x82FB;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH = 0x82FC;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_QUERY_WAIT_INVERTED = 0x8E17;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_QUERY_NO_WAIT_INVERTED = 0x8E18;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_QUERY_BY_REGION_WAIT_INVERTED = 0x8E19;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_QUERY_BY_REGION_NO_WAIT_INVERTED = 0x8E1A;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_CLIP_ORIGIN = 0x935C;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_CLIP_DEPTH_MODE = 0x935D;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_NEGATIVE_ONE_TO_ONE = 0x935E;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_ZERO_TO_ONE = 0x935F;
#endif
    }
}
#endif