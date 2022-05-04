#if (GL_VERSION_4_1 && GL_API)
public partial class gl { 
    public partial class Constants { 

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_VERTEX_SHADER_BIT = 0x00000001;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_FRAGMENT_SHADER_BIT = 0x00000002;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_GEOMETRY_SHADER_BIT = 0x00000004;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_TESS_CONTROL_SHADER_BIT = 0x00000008;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_TESS_EVALUATION_SHADER_BIT = 0x00000010;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FIXED = 0x140C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257;
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
        public const GLenum GL_MAX_VIEWPORTS = 0x825B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_VIEWPORT_SUBPIXEL_BITS = 0x825C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_VIEWPORT_BOUNDS_RANGE = 0x825D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_LAYER_PROVOKING_VERTEX = 0x825E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_VIEWPORT_INDEX_PROVOKING_VERTEX = 0x825F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNDEFINED_VERTEX = 0x8260;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PROGRAM_BINARY_LENGTH = 0x8741;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_NUM_PROGRAM_BINARY_FORMATS = 0x87FE;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PROGRAM_BINARY_FORMATS = 0x87FF;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGB565 = 0x8D62;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_LOW_FLOAT = 0x8DF0;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MEDIUM_FLOAT = 0x8DF1;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_HIGH_FLOAT = 0x8DF2;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_LOW_INT = 0x8DF3;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MEDIUM_INT = 0x8DF4;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_HIGH_INT = 0x8DF5;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SHADER_BINARY_FORMATS = 0x8DF8;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_NUM_SHADER_BINARY_FORMATS = 0x8DF9;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SHADER_COMPILER = 0x8DFA;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_VARYING_VECTORS = 0x8DFC;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_ALL_SHADER_BITS = 0xFFFFFFFF;
#endif
    }
}
#endif