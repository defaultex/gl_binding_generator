#if (GL_VERSION_1_4 && GL_API)
public partial class gl { 
    public partial class Constants { 

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_CONSTANT_COLOR = 0x8001;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_ONE_MINUS_CONSTANT_COLOR = 0x8002;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_CONSTANT_ALPHA = 0x8003;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_BLEND_COLOR = 0x8005;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_FUNC_ADD = 0x8006;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_MIN = 0x8007;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_MAX = 0x8008;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_BLEND_EQUATION = 0x8009;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_FUNC_SUBTRACT = 0x800A;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_FUNC_REVERSE_SUBTRACT = 0x800B;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_BLEND_DST_RGB = 0x80C8;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_BLEND_SRC_RGB = 0x80C9;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_BLEND_DST_ALPHA = 0x80CA;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_BLEND_SRC_ALPHA = 0x80CB;

#endif
        public const GLenum GL_POINT_SIZE_MIN = 0x8126;
        public const GLenum GL_POINT_SIZE_MAX = 0x8127;
        public const GLenum GL_POINT_FADE_THRESHOLD_SIZE = 0x8128;
        public const GLenum GL_POINT_DISTANCE_ATTENUATION = 0x8129;
        public const GLenum GL_GENERATE_MIPMAP = 0x8191;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_GENERATE_MIPMAP_HINT = 0x8192;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEPTH_COMPONENT16 = 0x81A5;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_DEPTH_COMPONENT24 = 0x81A6;

#endif
        public const GLenum GL_DEPTH_COMPONENT32 = 0x81A7;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_MIRRORED_REPEAT = 0x8370;

#endif
        public const GLenum GL_FOG_COORDINATE_SOURCE = 0x8450;
        public const GLenum GL_FOG_COORDINATE = 0x8451;
        public const GLenum GL_FRAGMENT_DEPTH = 0x8452;
        public const GLenum GL_CURRENT_FOG_COORDINATE = 0x8453;
        public const GLenum GL_FOG_COORDINATE_ARRAY_TYPE = 0x8454;
        public const GLenum GL_FOG_COORDINATE_ARRAY_STRIDE = 0x8455;
        public const GLenum GL_FOG_COORDINATE_ARRAY_POINTER = 0x8456;
        public const GLenum GL_FOG_COORDINATE_ARRAY = 0x8457;
        public const GLenum GL_COLOR_SUM = 0x8458;
        public const GLenum GL_CURRENT_SECONDARY_COLOR = 0x8459;
        public const GLenum GL_SECONDARY_COLOR_ARRAY_SIZE = 0x845A;
        public const GLenum GL_SECONDARY_COLOR_ARRAY_TYPE = 0x845B;
        public const GLenum GL_SECONDARY_COLOR_ARRAY_STRIDE = 0x845C;
        public const GLenum GL_SECONDARY_COLOR_ARRAY_POINTER = 0x845D;
        public const GLenum GL_SECONDARY_COLOR_ARRAY = 0x845E;

#if !GL_ES_VERSION_3_0
        public const GLenum GL_MAX_TEXTURE_LOD_BIAS = 0x84FD;

#endif
        public const GLenum GL_TEXTURE_FILTER_CONTROL = 0x8500;
        public const GLenum GL_TEXTURE_LOD_BIAS = 0x8501;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_INCR_WRAP = 0x8507;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_DECR_WRAP = 0x8508;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_TEXTURE_DEPTH_SIZE = 0x884A;

#endif
        public const GLenum GL_DEPTH_TEXTURE_MODE = 0x884B;

#if !GL_ES_VERSION_3_0
        public const GLenum GL_TEXTURE_COMPARE_MODE = 0x884C;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_TEXTURE_COMPARE_FUNC = 0x884D;

#endif
        public const GLenum GL_COMPARE_R_TO_TEXTURE = 0x884E;
    }
}
#endif