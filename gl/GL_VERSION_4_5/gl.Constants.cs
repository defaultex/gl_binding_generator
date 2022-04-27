#if (GL_VERSION_4_5 && GL_API)
public partial class gl { 
    public partial class Constants { 

#if !GL_ES_VERSION_3_2
        public const GLbitfield GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT = 0x00000004;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_ES_VERSION_3_2 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_NO_ERROR = 0;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_NONE = 0;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_BACK = 0x0405;

#endif

#if (!GL_ES_VERSION_3_2 && !GL_SC_VERSION_2_0)
        public const GLenum GL_CONTEXT_LOST = 0x0507;

#endif
        public const GLenum GL_TEXTURE_TARGET = 0x1006;

#if !GL_VERSION_1_1
        public const GLenum GL_TEXTURE_BINDING_1D = 0x8068;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_1)
        public const GLenum GL_TEXTURE_BINDING_2D = 0x8069;

#endif

#if (!GL_ES_VERSION_3_0 && !GL_VERSION_1_2)
        public const GLenum GL_TEXTURE_BINDING_3D = 0x806A;

#endif

#if (!GL_ES_VERSION_3_2 && !GL_SC_VERSION_2_0)
        public const GLenum GL_LOSE_CONTEXT_ON_RESET = 0x8252;

#endif

#if (!GL_ES_VERSION_3_2 && !GL_SC_VERSION_2_0)
        public const GLenum GL_GUILTY_CONTEXT_RESET = 0x8253;

#endif

#if (!GL_ES_VERSION_3_2 && !GL_SC_VERSION_2_0)
        public const GLenum GL_INNOCENT_CONTEXT_RESET = 0x8254;

#endif

#if (!GL_ES_VERSION_3_2 && !GL_SC_VERSION_2_0)
        public const GLenum GL_UNKNOWN_CONTEXT_RESET = 0x8255;

#endif

#if (!GL_ES_VERSION_3_2 && !GL_SC_VERSION_2_0)
        public const GLenum GL_RESET_NOTIFICATION_STRATEGY = 0x8256;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_NO_RESET_NOTIFICATION = 0x8261;

#endif
        public const GLenum GL_QUERY_TARGET = 0x82EA;
        public const GLenum GL_MAX_CULL_DISTANCES = 0x82F9;
        public const GLenum GL_MAX_COMBINED_CLIP_AND_CULL_DISTANCES = 0x82FA;
        public const GLenum GL_CONTEXT_RELEASE_BEHAVIOR = 0x82FB;
        public const GLenum GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH = 0x82FC;

#if !GL_VERSION_3_1
        public const GLenum GL_TEXTURE_BINDING_RECTANGLE = 0x84F6;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_TEXTURE_BINDING_CUBE_MAP = 0x8514;

#endif

#if !GL_VERSION_3_0
        public const GLenum GL_TEXTURE_BINDING_1D_ARRAY = 0x8C1C;

#endif

#if (!GL_ES_VERSION_3_0 && !GL_VERSION_3_0)
        public const GLenum GL_TEXTURE_BINDING_2D_ARRAY = 0x8C1D;

#endif

#if (!GL_ES_VERSION_3_2 && !GL_VERSION_3_1)
        public const GLenum GL_TEXTURE_BINDING_BUFFER = 0x8C2C;

#endif

#if !GL_VERSION_2_0
        public const GLenum GL_LOWER_LEFT = 0x8CA1;

#endif

#if !GL_VERSION_2_0
        public const GLenum GL_UPPER_LEFT = 0x8CA2;

#endif
        public const GLenum GL_QUERY_WAIT_INVERTED = 0x8E17;
        public const GLenum GL_QUERY_NO_WAIT_INVERTED = 0x8E18;
        public const GLenum GL_QUERY_BY_REGION_WAIT_INVERTED = 0x8E19;
        public const GLenum GL_QUERY_BY_REGION_NO_WAIT_INVERTED = 0x8E1A;

#if (!GL_ES_VERSION_3_2 && !GL_VERSION_4_0)
        public const GLenum GL_TEXTURE_BINDING_CUBE_MAP_ARRAY = 0x900A;

#endif

#if (!GL_ES_VERSION_3_1 && !GL_VERSION_3_2)
        public const GLenum GL_TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104;

#endif

#if (!GL_ES_VERSION_3_2 && !GL_VERSION_3_2)
        public const GLenum GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105;

#endif
        public const GLenum GL_CLIP_ORIGIN = 0x935C;
        public const GLenum GL_CLIP_DEPTH_MODE = 0x935D;
        public const GLenum GL_NEGATIVE_ONE_TO_ONE = 0x935E;
        public const GLenum GL_ZERO_TO_ONE = 0x935F;
    }
}
#endif