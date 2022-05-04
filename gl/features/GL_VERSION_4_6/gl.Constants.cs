#if (GL_VERSION_4_6 && GL_API)
public partial class gl { 
    public partial class Constants { 

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_NONE = 0;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_CONTEXT_FLAG_NO_ERROR_BIT = 0x00000008;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PARAMETER_BUFFER = 0x80EE;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PARAMETER_BUFFER_BINDING = 0x80EF;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TRANSFORM_FEEDBACK_OVERFLOW = 0x82EC;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TRANSFORM_FEEDBACK_STREAM_OVERFLOW = 0x82ED;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_VERTICES_SUBMITTED = 0x82EE;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PRIMITIVES_SUBMITTED = 0x82EF;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_VERTEX_SHADER_INVOCATIONS = 0x82F0;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TESS_CONTROL_SHADER_PATCHES = 0x82F1;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TESS_EVALUATION_SHADER_INVOCATIONS = 0x82F2;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_GEOMETRY_SHADER_PRIMITIVES_EMITTED = 0x82F3;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAGMENT_SHADER_INVOCATIONS = 0x82F4;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPUTE_SHADER_INVOCATIONS = 0x82F5;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_CLIPPING_INPUT_PRIMITIVES = 0x82F6;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_CLIPPING_OUTPUT_PRIMITIVES = 0x82F7;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_CONTEXT_RELEASE_BEHAVIOR = 0x82FB;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH = 0x82FC;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_MAX_ANISOTROPY = 0x84FE;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_TEXTURE_MAX_ANISOTROPY = 0x84FF;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_GEOMETRY_SHADER_INVOCATIONS = 0x887F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_POLYGON_OFFSET_CLAMP = 0x8E1B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SHADER_BINARY_FORMAT_SPIR_V = 0x9551;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SPIR_V_BINARY = 0x9552;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SPIR_V_EXTENSIONS = 0x9553;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_NUM_SPIR_V_EXTENSIONS = 0x9554;
#endif
    }
}
#endif