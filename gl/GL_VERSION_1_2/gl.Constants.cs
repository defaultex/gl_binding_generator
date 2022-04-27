#if (GL_VERSION_1_2 && GL_API)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_SMOOTH_POINT_SIZE_RANGE = 0x0B12;
        public const GLenum GL_SMOOTH_POINT_SIZE_GRANULARITY = 0x0B13;
        public const GLenum GL_SMOOTH_LINE_WIDTH_RANGE = 0x0B22;
        public const GLenum GL_SMOOTH_LINE_WIDTH_GRANULARITY = 0x0B23;
        public const GLenum GL_UNSIGNED_BYTE_3_3_2 = 0x8032;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034;

#endif
        public const GLenum GL_UNSIGNED_INT_8_8_8_8 = 0x8035;
        public const GLenum GL_UNSIGNED_INT_10_10_10_2 = 0x8036;
        public const GLenum GL_RESCALE_NORMAL = 0x803A;

#if !GL_ES_VERSION_3_0
        public const GLenum GL_TEXTURE_BINDING_3D = 0x806A;

#endif
        public const GLenum GL_PACK_SKIP_IMAGES = 0x806B;
        public const GLenum GL_PACK_IMAGE_HEIGHT = 0x806C;

#if !GL_ES_VERSION_3_0
        public const GLenum GL_UNPACK_SKIP_IMAGES = 0x806D;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_UNPACK_IMAGE_HEIGHT = 0x806E;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_TEXTURE_3D = 0x806F;

#endif
        public const GLenum GL_PROXY_TEXTURE_3D = 0x8070;

#if !GL_ES_VERSION_3_1
        public const GLenum GL_TEXTURE_DEPTH = 0x8071;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_TEXTURE_WRAP_R = 0x8072;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_MAX_3D_TEXTURE_SIZE = 0x8073;

#endif
        public const GLenum GL_BGR = 0x80E0;
        public const GLenum GL_BGRA = 0x80E1;

#if !GL_ES_VERSION_3_0
        public const GLenum GL_MAX_ELEMENTS_VERTICES = 0x80E8;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_MAX_ELEMENTS_INDICES = 0x80E9;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_CLAMP_TO_EDGE = 0x812F;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_TEXTURE_MIN_LOD = 0x813A;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_TEXTURE_MAX_LOD = 0x813B;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_TEXTURE_BASE_LEVEL = 0x813C;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_TEXTURE_MAX_LEVEL = 0x813D;

#endif
        public const GLenum GL_LIGHT_MODEL_COLOR_CONTROL = 0x81F8;
        public const GLenum GL_SINGLE_COLOR = 0x81F9;
        public const GLenum GL_SEPARATE_SPECULAR_COLOR = 0x81FA;
        public const GLenum GL_UNSIGNED_BYTE_2_3_3_REV = 0x8362;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_SHORT_5_6_5 = 0x8363;

#endif
        public const GLenum GL_UNSIGNED_SHORT_5_6_5_REV = 0x8364;
        public const GLenum GL_UNSIGNED_SHORT_4_4_4_4_REV = 0x8365;
        public const GLenum GL_UNSIGNED_SHORT_1_5_5_5_REV = 0x8366;
        public const GLenum GL_UNSIGNED_INT_8_8_8_8_REV = 0x8367;

#if !GL_ES_VERSION_3_0
        public const GLenum GL_UNSIGNED_INT_2_10_10_10_REV = 0x8368;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_ALIASED_POINT_SIZE_RANGE = 0x846D;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_ALIASED_LINE_WIDTH_RANGE = 0x846E;

#endif
    }
}
#endif