#if (GL_VERSION_3_2 && GL_API)
public partial class gl { 
    public partial class Constants { 

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_CONTEXT_CORE_PROFILE_BIT = 0x00000001;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_SYNC_FLUSH_COMMANDS_BIT = 0x00000001;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_CONTEXT_COMPATIBILITY_PROFILE_BIT = 0x00000002;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_LINES_ADJACENCY = 0x000A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_LINE_STRIP_ADJACENCY = 0x000B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TRIANGLES_ADJACENCY = 0x000C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TRIANGLE_STRIP_ADJACENCY = 0x000D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PROGRAM_POINT_SIZE = 0x8642;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEPTH_CLAMP = 0x864F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_CUBE_MAP_SEAMLESS = 0x884F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_GEOMETRY_VERTICES_OUT = 0x8916;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_GEOMETRY_INPUT_TYPE = 0x8917;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_GEOMETRY_OUTPUT_TYPE = 0x8918;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS = 0x8C29;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_LAYERED = 0x8DA7;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS = 0x8DA8;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_GEOMETRY_SHADER = 0x8DD9;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_GEOMETRY_UNIFORM_COMPONENTS = 0x8DDF;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_GEOMETRY_OUTPUT_VERTICES = 0x8DE0;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS = 0x8DE1;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION = 0x8E4C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FIRST_VERTEX_CONVENTION = 0x8E4D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_LAST_VERTEX_CONVENTION = 0x8E4E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PROVOKING_VERTEX = 0x8E4F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SAMPLE_POSITION = 0x8E50;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SAMPLE_MASK = 0x8E51;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SAMPLE_MASK_VALUE = 0x8E52;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_SAMPLE_MASK_WORDS = 0x8E59;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_2D_MULTISAMPLE = 0x9100;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PROXY_TEXTURE_2D_MULTISAMPLE = 0x9101;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9103;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_SAMPLES = 0x9106;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_FIXED_SAMPLE_LOCATIONS = 0x9107;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SAMPLER_2D_MULTISAMPLE = 0x9108;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_INT_SAMPLER_2D_MULTISAMPLE = 0x9109;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 0x910A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_COLOR_TEXTURE_SAMPLES = 0x910E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_DEPTH_TEXTURE_SAMPLES = 0x910F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_INTEGER_SAMPLES = 0x9110;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_SERVER_WAIT_TIMEOUT = 0x9111;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_OBJECT_TYPE = 0x9112;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SYNC_CONDITION = 0x9113;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SYNC_STATUS = 0x9114;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SYNC_FLAGS = 0x9115;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SYNC_FENCE = 0x9116;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SYNC_GPU_COMMANDS_COMPLETE = 0x9117;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNALED = 0x9118;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SIGNALED = 0x9119;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_ALREADY_SIGNALED = 0x911A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TIMEOUT_EXPIRED = 0x911B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_CONDITION_SATISFIED = 0x911C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_WAIT_FAILED = 0x911D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_VERTEX_OUTPUT_COMPONENTS = 0x9122;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_GEOMETRY_INPUT_COMPONENTS = 0x9123;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_GEOMETRY_OUTPUT_COMPONENTS = 0x9124;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_FRAGMENT_INPUT_COMPONENTS = 0x9125;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_CONTEXT_PROFILE_MASK = 0x9126;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLuint64 GL_TIMEOUT_IGNORED = 0xFFFFFFFFFFFFFFFF;
#endif
    }
}
#endif