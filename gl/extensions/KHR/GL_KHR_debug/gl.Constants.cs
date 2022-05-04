#if (GL_KHR_debug && (GL_API || GLCORE_API || GLES1_API || GLES2_API))
public partial class khr { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_CONTEXT_FLAG_DEBUG_BIT = 0x00000002;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONTEXT_FLAG_DEBUG_BIT_KHR = 0x00000002;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_STACK_OVERFLOW = 0x0503;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_STACK_OVERFLOW_KHR = 0x0503;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_STACK_UNDERFLOW = 0x0504;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_STACK_UNDERFLOW_KHR = 0x0504;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_VERTEX_ARRAY = 0x8074;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VERTEX_ARRAY_KHR = 0x8074;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_OUTPUT_SYNCHRONOUS = 0x8242;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEBUG_OUTPUT_SYNCHRONOUS_KHR = 0x8242;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH = 0x8243;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_KHR = 0x8243;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_CALLBACK_FUNCTION = 0x8244;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEBUG_CALLBACK_FUNCTION_KHR = 0x8244;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_CALLBACK_USER_PARAM = 0x8245;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEBUG_CALLBACK_USER_PARAM_KHR = 0x8245;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_SOURCE_API = 0x8246;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEBUG_SOURCE_API_KHR = 0x8246;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_SOURCE_WINDOW_SYSTEM = 0x8247;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEBUG_SOURCE_WINDOW_SYSTEM_KHR = 0x8247;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_SOURCE_SHADER_COMPILER = 0x8248;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEBUG_SOURCE_SHADER_COMPILER_KHR = 0x8248;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_SOURCE_THIRD_PARTY = 0x8249;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEBUG_SOURCE_THIRD_PARTY_KHR = 0x8249;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_SOURCE_APPLICATION = 0x824A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEBUG_SOURCE_APPLICATION_KHR = 0x824A;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_SOURCE_OTHER = 0x824B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEBUG_SOURCE_OTHER_KHR = 0x824B;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_TYPE_ERROR = 0x824C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEBUG_TYPE_ERROR_KHR = 0x824C;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR = 0x824D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_KHR = 0x824D;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR = 0x824E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_KHR = 0x824E;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_TYPE_PORTABILITY = 0x824F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEBUG_TYPE_PORTABILITY_KHR = 0x824F;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_TYPE_PERFORMANCE = 0x8250;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEBUG_TYPE_PERFORMANCE_KHR = 0x8250;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_TYPE_OTHER = 0x8251;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEBUG_TYPE_OTHER_KHR = 0x8251;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_TYPE_MARKER = 0x8268;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEBUG_TYPE_MARKER_KHR = 0x8268;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_TYPE_PUSH_GROUP = 0x8269;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEBUG_TYPE_PUSH_GROUP_KHR = 0x8269;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_TYPE_POP_GROUP = 0x826A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEBUG_TYPE_POP_GROUP_KHR = 0x826A;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_SEVERITY_NOTIFICATION = 0x826B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEBUG_SEVERITY_NOTIFICATION_KHR = 0x826B;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_DEBUG_GROUP_STACK_DEPTH = 0x826C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_DEBUG_GROUP_STACK_DEPTH_KHR = 0x826C;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_GROUP_STACK_DEPTH = 0x826D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEBUG_GROUP_STACK_DEPTH_KHR = 0x826D;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_BUFFER = 0x82E0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BUFFER_KHR = 0x82E0;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_SHADER = 0x82E1;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADER_KHR = 0x82E1;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_PROGRAM = 0x82E2;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PROGRAM_KHR = 0x82E2;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_QUERY = 0x82E3;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_QUERY_KHR = 0x82E3;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_PROGRAM_PIPELINE = 0x82E4;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PROGRAM_PIPELINE_KHR = 0x82E4;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_SAMPLER = 0x82E6;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLER_KHR = 0x82E6;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DISPLAY_LIST = 0x82E7;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_LABEL_LENGTH = 0x82E8;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_LABEL_LENGTH_KHR = 0x82E8;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_DEBUG_MESSAGE_LENGTH = 0x9143;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_DEBUG_MESSAGE_LENGTH_KHR = 0x9143;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_DEBUG_LOGGED_MESSAGES = 0x9144;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_DEBUG_LOGGED_MESSAGES_KHR = 0x9144;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_LOGGED_MESSAGES = 0x9145;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEBUG_LOGGED_MESSAGES_KHR = 0x9145;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_SEVERITY_HIGH = 0x9146;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEBUG_SEVERITY_HIGH_KHR = 0x9146;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_SEVERITY_MEDIUM = 0x9147;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEBUG_SEVERITY_MEDIUM_KHR = 0x9147;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_SEVERITY_LOW = 0x9148;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEBUG_SEVERITY_LOW_KHR = 0x9148;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_OUTPUT = 0x92E0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEBUG_OUTPUT_KHR = 0x92E0;
#endif
    }
}
#endif