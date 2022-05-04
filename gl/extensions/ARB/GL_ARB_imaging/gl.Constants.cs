#if (GL_ARB_imaging && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_CONSTANT_COLOR = 0x8001;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_ONE_MINUS_CONSTANT_COLOR = 0x8002;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_CONSTANT_ALPHA = 0x8003;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_BLEND_COLOR = 0x8005;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_FUNC_ADD = 0x8006;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_MIN = 0x8007;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_MAX = 0x8008;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_BLEND_EQUATION = 0x8009;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_FUNC_SUBTRACT = 0x800A;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_FUNC_REVERSE_SUBTRACT = 0x800B;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_CONVOLUTION_1D = 0x8010;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_CONVOLUTION_2D = 0x8011;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_SEPARABLE_2D = 0x8012;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONVOLUTION_BORDER_MODE = 0x8013;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONVOLUTION_FILTER_SCALE = 0x8014;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONVOLUTION_FILTER_BIAS = 0x8015;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_REDUCE = 0x8016;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONVOLUTION_FORMAT = 0x8017;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONVOLUTION_WIDTH = 0x8018;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONVOLUTION_HEIGHT = 0x8019;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_CONVOLUTION_WIDTH = 0x801A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_CONVOLUTION_HEIGHT = 0x801B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_CONVOLUTION_RED_SCALE = 0x801C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_CONVOLUTION_GREEN_SCALE = 0x801D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_CONVOLUTION_BLUE_SCALE = 0x801E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_CONVOLUTION_ALPHA_SCALE = 0x801F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_CONVOLUTION_RED_BIAS = 0x8020;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_CONVOLUTION_GREEN_BIAS = 0x8021;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_CONVOLUTION_BLUE_BIAS = 0x8022;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_CONVOLUTION_ALPHA_BIAS = 0x8023;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_HISTOGRAM = 0x8024;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_PROXY_HISTOGRAM = 0x8025;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HISTOGRAM_WIDTH = 0x8026;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HISTOGRAM_FORMAT = 0x8027;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HISTOGRAM_RED_SIZE = 0x8028;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HISTOGRAM_GREEN_SIZE = 0x8029;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HISTOGRAM_BLUE_SIZE = 0x802A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HISTOGRAM_ALPHA_SIZE = 0x802B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HISTOGRAM_LUMINANCE_SIZE = 0x802C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HISTOGRAM_SINK = 0x802D;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_MINMAX = 0x802E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MINMAX_FORMAT = 0x802F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MINMAX_SINK = 0x8030;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TABLE_TOO_LARGE = 0x8031;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_MATRIX = 0x80B1;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_MATRIX_STACK_DEPTH = 0x80B2;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_COLOR_MATRIX_STACK_DEPTH = 0x80B3;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_COLOR_MATRIX_RED_SCALE = 0x80B4;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_COLOR_MATRIX_GREEN_SCALE = 0x80B5;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_COLOR_MATRIX_BLUE_SCALE = 0x80B6;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_COLOR_MATRIX_ALPHA_SCALE = 0x80B7;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_COLOR_MATRIX_RED_BIAS = 0x80B8;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_COLOR_MATRIX_GREEN_BIAS = 0x80B9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_COLOR_MATRIX_BLUE_BIAS = 0x80BA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_COLOR_MATRIX_ALPHA_BIAS = 0x80BB;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_TABLE = 0x80D0;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_POST_CONVOLUTION_COLOR_TABLE = 0x80D1;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D2;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_PROXY_COLOR_TABLE = 0x80D3;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_PROXY_POST_CONVOLUTION_COLOR_TABLE = 0x80D4;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D5;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_TABLE_SCALE = 0x80D6;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_TABLE_BIAS = 0x80D7;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_TABLE_FORMAT = 0x80D8;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_TABLE_WIDTH = 0x80D9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_TABLE_RED_SIZE = 0x80DA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_TABLE_GREEN_SIZE = 0x80DB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_TABLE_BLUE_SIZE = 0x80DC;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_TABLE_ALPHA_SIZE = 0x80DD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_TABLE_LUMINANCE_SIZE = 0x80DE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_TABLE_INTENSITY_SIZE = 0x80DF;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONSTANT_BORDER = 0x8151;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_REPLICATE_BORDER = 0x8153;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONVOLUTION_BORDER_COLOR = 0x8154;
#endif
    }
}
#endif