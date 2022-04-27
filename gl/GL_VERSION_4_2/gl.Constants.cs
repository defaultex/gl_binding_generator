#if (GL_VERSION_4_2 && GL_API)
public partial class gl { 
    public partial class Constants { 

#if !GL_ES_VERSION_3_1
        public const GLbitfield GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT = 0x00000001;

#endif

#if !GL_ES_VERSION_3_1
        public const GLbitfield GL_ELEMENT_ARRAY_BARRIER_BIT = 0x00000002;

#endif

#if !GL_ES_VERSION_3_1
        public const GLbitfield GL_UNIFORM_BARRIER_BIT = 0x00000004;

#endif

#if !GL_ES_VERSION_3_1
        public const GLbitfield GL_TEXTURE_FETCH_BARRIER_BIT = 0x00000008;

#endif

#if !GL_ES_VERSION_3_1
        public const GLbitfield GL_SHADER_IMAGE_ACCESS_BARRIER_BIT = 0x00000020;

#endif

#if !GL_ES_VERSION_3_1
        public const GLbitfield GL_COMMAND_BARRIER_BIT = 0x00000040;

#endif

#if !GL_ES_VERSION_3_1
        public const GLbitfield GL_PIXEL_BUFFER_BARRIER_BIT = 0x00000080;

#endif

#if !GL_ES_VERSION_3_1
        public const GLbitfield GL_TEXTURE_UPDATE_BARRIER_BIT = 0x00000100;

#endif

#if !GL_ES_VERSION_3_1
        public const GLbitfield GL_BUFFER_UPDATE_BARRIER_BIT = 0x00000200;

#endif

#if !GL_ES_VERSION_3_1
        public const GLbitfield GL_FRAMEBUFFER_BARRIER_BIT = 0x00000400;

#endif

#if !GL_ES_VERSION_3_1
        public const GLbitfield GL_TRANSFORM_FEEDBACK_BARRIER_BIT = 0x00000800;

#endif

#if !GL_ES_VERSION_3_1
        public const GLbitfield GL_ATOMIC_COUNTER_BARRIER_BIT = 0x00001000;

#endif

#if !GL_ES_VERSION_3_1
        public const GLbitfield GL_ALL_BARRIER_BITS = 0xFFFFFFFF;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_TRANSFORM_FEEDBACK_PAUSED = 0x8E23;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_TRANSFORM_FEEDBACK_ACTIVE = 0x8E24;

#endif
        public const GLenum GL_COMPRESSED_RGBA_BPTC_UNORM = 0x8E8C;
        public const GLenum GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM = 0x8E8D;
        public const GLenum GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT = 0x8E8E;
        public const GLenum GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT = 0x8E8F;

#if !GL_ES_VERSION_3_0
        public const GLenum GL_COPY_READ_BUFFER_BINDING = 0x8F36;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_COPY_WRITE_BUFFER_BINDING = 0x8F37;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_MAX_IMAGE_UNITS = 0x8F38;

#endif
        public const GLenum GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS = 0x8F39;

#if !GL_ES_VERSION_3_1
        public const GLenum GL_IMAGE_BINDING_NAME = 0x8F3A;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_IMAGE_BINDING_LEVEL = 0x8F3B;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_IMAGE_BINDING_LAYERED = 0x8F3C;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_IMAGE_BINDING_LAYER = 0x8F3D;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_IMAGE_BINDING_ACCESS = 0x8F3E;

#endif
        public const GLenum GL_IMAGE_1D = 0x904C;

#if !GL_ES_VERSION_3_1
        public const GLenum GL_IMAGE_2D = 0x904D;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_IMAGE_3D = 0x904E;

#endif
        public const GLenum GL_IMAGE_2D_RECT = 0x904F;

#if !GL_ES_VERSION_3_1
        public const GLenum GL_IMAGE_CUBE = 0x9050;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_IMAGE_BUFFER = 0x9051;

#endif
        public const GLenum GL_IMAGE_1D_ARRAY = 0x9052;

#if !GL_ES_VERSION_3_1
        public const GLenum GL_IMAGE_2D_ARRAY = 0x9053;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_IMAGE_CUBE_MAP_ARRAY = 0x9054;

#endif
        public const GLenum GL_IMAGE_2D_MULTISAMPLE = 0x9055;
        public const GLenum GL_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9056;
        public const GLenum GL_INT_IMAGE_1D = 0x9057;

#if !GL_ES_VERSION_3_1
        public const GLenum GL_INT_IMAGE_2D = 0x9058;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_INT_IMAGE_3D = 0x9059;

#endif
        public const GLenum GL_INT_IMAGE_2D_RECT = 0x905A;

#if !GL_ES_VERSION_3_1
        public const GLenum GL_INT_IMAGE_CUBE = 0x905B;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_INT_IMAGE_BUFFER = 0x905C;

#endif
        public const GLenum GL_INT_IMAGE_1D_ARRAY = 0x905D;

#if !GL_ES_VERSION_3_1
        public const GLenum GL_INT_IMAGE_2D_ARRAY = 0x905E;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_INT_IMAGE_CUBE_MAP_ARRAY = 0x905F;

#endif
        public const GLenum GL_INT_IMAGE_2D_MULTISAMPLE = 0x9060;
        public const GLenum GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9061;
        public const GLenum GL_UNSIGNED_INT_IMAGE_1D = 0x9062;

#if !GL_ES_VERSION_3_1
        public const GLenum GL_UNSIGNED_INT_IMAGE_2D = 0x9063;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_UNSIGNED_INT_IMAGE_3D = 0x9064;

#endif
        public const GLenum GL_UNSIGNED_INT_IMAGE_2D_RECT = 0x9065;

#if !GL_ES_VERSION_3_1
        public const GLenum GL_UNSIGNED_INT_IMAGE_CUBE = 0x9066;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_UNSIGNED_INT_IMAGE_BUFFER = 0x9067;

#endif
        public const GLenum GL_UNSIGNED_INT_IMAGE_1D_ARRAY = 0x9068;

#if !GL_ES_VERSION_3_1
        public const GLenum GL_UNSIGNED_INT_IMAGE_2D_ARRAY = 0x9069;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY = 0x906A;

#endif
        public const GLenum GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE = 0x906B;
        public const GLenum GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x906C;
        public const GLenum GL_MAX_IMAGE_SAMPLES = 0x906D;

#if !GL_ES_VERSION_3_1
        public const GLenum GL_IMAGE_BINDING_FORMAT = 0x906E;

#endif
        public const GLenum GL_MIN_MAP_BUFFER_ALIGNMENT = 0x90BC;

#if !GL_ES_VERSION_3_1
        public const GLenum GL_IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_IMAGE_FORMAT_COMPATIBILITY_BY_SIZE = 0x90C8;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_IMAGE_FORMAT_COMPATIBILITY_BY_CLASS = 0x90C9;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_MAX_VERTEX_IMAGE_UNIFORMS = 0x90CA;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS = 0x90CB;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS = 0x90CC;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_MAX_GEOMETRY_IMAGE_UNIFORMS = 0x90CD;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_MAX_FRAGMENT_IMAGE_UNIFORMS = 0x90CE;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_MAX_COMBINED_IMAGE_UNIFORMS = 0x90CF;

#endif
        public const GLenum GL_UNPACK_COMPRESSED_BLOCK_WIDTH = 0x9127;
        public const GLenum GL_UNPACK_COMPRESSED_BLOCK_HEIGHT = 0x9128;
        public const GLenum GL_UNPACK_COMPRESSED_BLOCK_DEPTH = 0x9129;
        public const GLenum GL_UNPACK_COMPRESSED_BLOCK_SIZE = 0x912A;
        public const GLenum GL_PACK_COMPRESSED_BLOCK_WIDTH = 0x912B;
        public const GLenum GL_PACK_COMPRESSED_BLOCK_HEIGHT = 0x912C;
        public const GLenum GL_PACK_COMPRESSED_BLOCK_DEPTH = 0x912D;
        public const GLenum GL_PACK_COMPRESSED_BLOCK_SIZE = 0x912E;

#if (!GL_ES_VERSION_3_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_IMMUTABLE_FORMAT = 0x912F;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_ATOMIC_COUNTER_BUFFER = 0x92C0;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_ATOMIC_COUNTER_BUFFER_BINDING = 0x92C1;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_ATOMIC_COUNTER_BUFFER_START = 0x92C2;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_ATOMIC_COUNTER_BUFFER_SIZE = 0x92C3;

#endif
        public const GLenum GL_ATOMIC_COUNTER_BUFFER_DATA_SIZE = 0x92C4;
        public const GLenum GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS = 0x92C5;
        public const GLenum GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES = 0x92C6;
        public const GLenum GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER = 0x92C7;
        public const GLenum GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER = 0x92C8;
        public const GLenum GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x92C9;
        public const GLenum GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER = 0x92CA;
        public const GLenum GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER = 0x92CB;

#if !GL_ES_VERSION_3_1
        public const GLenum GL_MAX_VERTEX_ATOMIC_COUNTER_BUFFERS = 0x92CC;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS = 0x92CD;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS = 0x92CE;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS = 0x92CF;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS = 0x92D0;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_MAX_COMBINED_ATOMIC_COUNTER_BUFFERS = 0x92D1;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_MAX_VERTEX_ATOMIC_COUNTERS = 0x92D2;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS = 0x92D3;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS = 0x92D4;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_MAX_GEOMETRY_ATOMIC_COUNTERS = 0x92D5;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_MAX_FRAGMENT_ATOMIC_COUNTERS = 0x92D6;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_MAX_COMBINED_ATOMIC_COUNTERS = 0x92D7;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_MAX_ATOMIC_COUNTER_BUFFER_SIZE = 0x92D8;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9;

#endif
        public const GLenum GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX = 0x92DA;

#if !GL_ES_VERSION_3_1
        public const GLenum GL_UNSIGNED_INT_ATOMIC_COUNTER = 0x92DB;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_MAX_ATOMIC_COUNTER_BUFFER_BINDINGS = 0x92DC;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_NUM_SAMPLE_COUNTS = 0x9380;

#endif
    }
}
#endif