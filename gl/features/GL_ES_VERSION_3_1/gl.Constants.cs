#if (GL_ES_VERSION_3_1 && GLES2_API)
public partial class gles2 { 
    public partial class Constants { 

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT = 0x00000001;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_VERTEX_SHADER_BIT = 0x00000001;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_ELEMENT_ARRAY_BARRIER_BIT = 0x00000002;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_FRAGMENT_SHADER_BIT = 0x00000002;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_UNIFORM_BARRIER_BIT = 0x00000004;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_TEXTURE_FETCH_BARRIER_BIT = 0x00000008;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_COMPUTE_SHADER_BIT = 0x00000020;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_SHADER_IMAGE_ACCESS_BARRIER_BIT = 0x00000020;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_COMMAND_BARRIER_BIT = 0x00000040;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_PIXEL_BUFFER_BARRIER_BIT = 0x00000080;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_TEXTURE_UPDATE_BARRIER_BIT = 0x00000100;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_BUFFER_UPDATE_BARRIER_BIT = 0x00000200;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_FRAMEBUFFER_BARRIER_BIT = 0x00000400;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_TRANSFORM_FEEDBACK_BARRIER_BIT = 0x00000800;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_ATOMIC_COUNTER_BARRIER_BIT = 0x00001000;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_WIDTH = 0x1000;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_HEIGHT = 0x1001;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_INTERNAL_FORMAT = 0x1003;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_STENCIL_INDEX = 0x1901;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_SHADER_STORAGE_BARRIER_BIT = 0x00002000;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_RED_SIZE = 0x805C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_GREEN_SIZE = 0x805D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_BLUE_SIZE = 0x805E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_ALPHA_SIZE = 0x805F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_DEPTH = 0x8071;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PROGRAM_SEPARABLE = 0x8258;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_ACTIVE_PROGRAM = 0x8259;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PROGRAM_PIPELINE_BINDING = 0x825A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_COMPUTE_SHARED_MEMORY_SIZE = 0x8262;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_COMPUTE_UNIFORM_COMPONENTS = 0x8263;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS = 0x8264;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_COMPUTE_ATOMIC_COUNTERS = 0x8265;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS = 0x8266;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPUTE_WORK_GROUP_SIZE = 0x8267;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_UNIFORM_LOCATIONS = 0x826E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_VERTEX_ATTRIB_BINDING = 0x82D4;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_VERTEX_BINDING_DIVISOR = 0x82D6;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_VERTEX_BINDING_OFFSET = 0x82D7;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_VERTEX_BINDING_STRIDE = 0x82D8;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D9;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_VERTEX_ATTRIB_BINDINGS = 0x82DA;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_VERTEX_ATTRIB_STRIDE = 0x82E5;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_COMPRESSED = 0x86A1;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_DEPTH_SIZE = 0x884A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_READ_ONLY = 0x88B8;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_WRITE_ONLY = 0x88B9;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_READ_WRITE = 0x88BA;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_STENCIL_SIZE = 0x88F1;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_RED_TYPE = 0x8C10;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_GREEN_TYPE = 0x8C11;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_BLUE_TYPE = 0x8C12;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_ALPHA_TYPE = 0x8C13;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_DEPTH_TYPE = 0x8C16;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_SHARED_SIZE = 0x8C3F;
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
        public const GLenum GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_IMAGE_UNITS = 0x8F38;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_COMBINED_SHADER_OUTPUT_RESOURCES = 0x8F39;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_IMAGE_BINDING_NAME = 0x8F3A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_IMAGE_BINDING_LEVEL = 0x8F3B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_IMAGE_BINDING_LAYERED = 0x8F3C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_IMAGE_BINDING_LAYER = 0x8F3D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_IMAGE_BINDING_ACCESS = 0x8F3E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DRAW_INDIRECT_BUFFER = 0x8F3F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DRAW_INDIRECT_BUFFER_BINDING = 0x8F43;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_VERTEX_BINDING_BUFFER = 0x8F4F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_IMAGE_2D = 0x904D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_IMAGE_3D = 0x904E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_IMAGE_CUBE = 0x9050;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_IMAGE_2D_ARRAY = 0x9053;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_INT_IMAGE_2D = 0x9058;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_INT_IMAGE_3D = 0x9059;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_INT_IMAGE_CUBE = 0x905B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_INT_IMAGE_2D_ARRAY = 0x905E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_IMAGE_2D = 0x9063;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_IMAGE_3D = 0x9064;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_IMAGE_CUBE = 0x9066;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_IMAGE_2D_ARRAY = 0x9069;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_IMAGE_BINDING_FORMAT = 0x906E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_IMAGE_FORMAT_COMPATIBILITY_BY_SIZE = 0x90C8;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_IMAGE_FORMAT_COMPATIBILITY_BY_CLASS = 0x90C9;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_VERTEX_IMAGE_UNIFORMS = 0x90CA;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_FRAGMENT_IMAGE_UNIFORMS = 0x90CE;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_COMBINED_IMAGE_UNIFORMS = 0x90CF;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SHADER_STORAGE_BUFFER = 0x90D2;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SHADER_STORAGE_BUFFER_BINDING = 0x90D3;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SHADER_STORAGE_BUFFER_START = 0x90D4;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SHADER_STORAGE_BUFFER_SIZE = 0x90D5;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_VERTEX_SHADER_STORAGE_BLOCKS = 0x90D6;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_FRAGMENT_SHADER_STORAGE_BLOCKS = 0x90DA;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_COMPUTE_SHADER_STORAGE_BLOCKS = 0x90DB;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_COMBINED_SHADER_STORAGE_BLOCKS = 0x90DC;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_SHADER_STORAGE_BUFFER_BINDINGS = 0x90DD;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_SHADER_STORAGE_BLOCK_SIZE = 0x90DE;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT = 0x90DF;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEPTH_STENCIL_TEXTURE_MODE = 0x90EA;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_COMPUTE_WORK_GROUP_INVOCATIONS = 0x90EB;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DISPATCH_INDIRECT_BUFFER = 0x90EE;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DISPATCH_INDIRECT_BUFFER_BINDING = 0x90EF;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_2D_MULTISAMPLE = 0x9100;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104;
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
        public const GLenum GL_MAX_COLOR_TEXTURE_SAMPLES = 0x910E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_DEPTH_TEXTURE_SAMPLES = 0x910F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_INTEGER_SAMPLES = 0x9110;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPUTE_SHADER = 0x91B9;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_COMPUTE_UNIFORM_BLOCKS = 0x91BB;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_COMPUTE_TEXTURE_IMAGE_UNITS = 0x91BC;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_COMPUTE_IMAGE_UNIFORMS = 0x91BD;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_COMPUTE_WORK_GROUP_COUNT = 0x91BE;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_COMPUTE_WORK_GROUP_SIZE = 0x91BF;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_ATOMIC_COUNTER_BUFFER = 0x92C0;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_ATOMIC_COUNTER_BUFFER_BINDING = 0x92C1;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_ATOMIC_COUNTER_BUFFER_START = 0x92C2;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_ATOMIC_COUNTER_BUFFER_SIZE = 0x92C3;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_VERTEX_ATOMIC_COUNTER_BUFFERS = 0x92CC;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS = 0x92D0;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_COMBINED_ATOMIC_COUNTER_BUFFERS = 0x92D1;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_VERTEX_ATOMIC_COUNTERS = 0x92D2;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_FRAGMENT_ATOMIC_COUNTERS = 0x92D6;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_COMBINED_ATOMIC_COUNTERS = 0x92D7;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_ATOMIC_COUNTER_BUFFER_SIZE = 0x92D8;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_ATOMIC_COUNTER = 0x92DB;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_ATOMIC_COUNTER_BUFFER_BINDINGS = 0x92DC;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM = 0x92E1;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_BLOCK = 0x92E2;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PROGRAM_INPUT = 0x92E3;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PROGRAM_OUTPUT = 0x92E4;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_BUFFER_VARIABLE = 0x92E5;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SHADER_STORAGE_BLOCK = 0x92E6;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TRANSFORM_FEEDBACK_VARYING = 0x92F4;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_ACTIVE_RESOURCES = 0x92F5;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_NAME_LENGTH = 0x92F6;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_NUM_ACTIVE_VARIABLES = 0x92F7;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_NAME_LENGTH = 0x92F9;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TYPE = 0x92FA;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_ARRAY_SIZE = 0x92FB;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_OFFSET = 0x92FC;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_BLOCK_INDEX = 0x92FD;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_ARRAY_STRIDE = 0x92FE;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MATRIX_STRIDE = 0x92FF;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_IS_ROW_MAJOR = 0x9300;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_ATOMIC_COUNTER_BUFFER_INDEX = 0x9301;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_BUFFER_BINDING = 0x9302;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_BUFFER_DATA_SIZE = 0x9303;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_NUM_ACTIVE_VARIABLES = 0x9304;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_ACTIVE_VARIABLES = 0x9305;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_REFERENCED_BY_VERTEX_SHADER = 0x9306;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_REFERENCED_BY_FRAGMENT_SHADER = 0x930A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_REFERENCED_BY_COMPUTE_SHADER = 0x930B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TOP_LEVEL_ARRAY_SIZE = 0x930C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TOP_LEVEL_ARRAY_STRIDE = 0x930D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_LOCATION = 0x930E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_DEFAULT_WIDTH = 0x9310;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_FRAMEBUFFER_WIDTH = 0x9315;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_FRAMEBUFFER_HEIGHT = 0x9316;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_FRAMEBUFFER_SAMPLES = 0x9318;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_ALL_BARRIER_BITS = 0xFFFFFFFF;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_ALL_SHADER_BITS = 0xFFFFFFFF;
#endif
    }
}
#endif