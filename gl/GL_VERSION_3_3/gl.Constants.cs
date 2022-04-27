#if (GL_VERSION_3_3 && GL_API)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TIME_ELAPSED = 0x88BF;
        public const GLenum GL_SRC1_COLOR = 0x88F9;
        public const GLenum GL_ONE_MINUS_SRC1_COLOR = 0x88FA;
        public const GLenum GL_ONE_MINUS_SRC1_ALPHA = 0x88FB;
        public const GLenum GL_MAX_DUAL_SOURCE_DRAW_BUFFERS = 0x88FC;

#if !GL_ES_VERSION_3_0
        public const GLenum GL_VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_SAMPLER_BINDING = 0x8919;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_ANY_SAMPLES_PASSED = 0x8C2F;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_INT_2_10_10_10_REV = 0x8D9F;

#endif
        public const GLenum GL_TIMESTAMP = 0x8E28;

#if !GL_ES_VERSION_3_0
        public const GLenum GL_TEXTURE_SWIZZLE_R = 0x8E42;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_TEXTURE_SWIZZLE_G = 0x8E43;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_TEXTURE_SWIZZLE_B = 0x8E44;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_TEXTURE_SWIZZLE_A = 0x8E45;

#endif
        public const GLenum GL_TEXTURE_SWIZZLE_RGBA = 0x8E46;

#if !GL_ES_VERSION_3_0
        public const GLenum GL_RGB10_A2UI = 0x906F;

#endif
    }
}
#endif