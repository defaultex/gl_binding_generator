#if (GL_VERSION_4_0 && GL_API)
public partial class gl { 
    public partial class Constants { 

#if (!GL_ES_VERSION_3_2 && !GL_VERSION_1_0)
        public const GLenum GL_QUADS = 0x0007;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_PATCHES = 0x000E;

#endif
        public const GLenum GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER = 0x84F0;
        public const GLenum GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x84F1;

#if !GL_ES_VERSION_3_2
        public const GLenum GL_MAX_TESS_CONTROL_INPUT_COMPONENTS = 0x886C;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS = 0x886D;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_GEOMETRY_SHADER_INVOCATIONS = 0x887F;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_SAMPLE_SHADING = 0x8C36;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_MIN_SAMPLE_SHADING_VALUE = 0x8C37;

#endif
        public const GLenum GL_ACTIVE_SUBROUTINES = 0x8DE5;
        public const GLenum GL_ACTIVE_SUBROUTINE_UNIFORMS = 0x8DE6;
        public const GLenum GL_MAX_SUBROUTINES = 0x8DE7;
        public const GLenum GL_MAX_SUBROUTINE_UNIFORM_LOCATIONS = 0x8DE8;

#if !GL_ES_VERSION_3_2
        public const GLenum GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E1E;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E1F;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_TRANSFORM_FEEDBACK = 0x8E22;

#endif
        public const GLenum GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED = 0x8E23;
        public const GLenum GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE = 0x8E24;

#if !GL_ES_VERSION_3_0
        public const GLenum GL_TRANSFORM_FEEDBACK_BINDING = 0x8E25;

#endif
        public const GLenum GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS = 0x8E47;
        public const GLenum GL_ACTIVE_SUBROUTINE_MAX_LENGTH = 0x8E48;
        public const GLenum GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH = 0x8E49;
        public const GLenum GL_NUM_COMPATIBLE_SUBROUTINES = 0x8E4A;
        public const GLenum GL_COMPATIBLE_SUBROUTINES = 0x8E4B;

#if !GL_ES_VERSION_3_2
        public const GLenum GL_MAX_GEOMETRY_SHADER_INVOCATIONS = 0x8E5A;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_MIN_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5B;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_MAX_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5C;

#endif

#if !GL_ES_VERSION_3_2
        public const GLbitfield GL_FRAGMENT_INTERPOLATION_OFFSET_BITS = 0x8E5D;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5E;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5F;

#endif
        public const GLenum GL_MAX_TRANSFORM_FEEDBACK_BUFFERS = 0x8E70;
        public const GLenum GL_MAX_VERTEX_STREAMS = 0x8E71;

#if !GL_ES_VERSION_3_2
        public const GLenum GL_PATCH_VERTICES = 0x8E72;

#endif
        public const GLenum GL_PATCH_DEFAULT_INNER_LEVEL = 0x8E73;
        public const GLenum GL_PATCH_DEFAULT_OUTER_LEVEL = 0x8E74;

#if !GL_ES_VERSION_3_2
        public const GLenum GL_TESS_CONTROL_OUTPUT_VERTICES = 0x8E75;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_TESS_GEN_MODE = 0x8E76;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_TESS_GEN_SPACING = 0x8E77;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_TESS_GEN_VERTEX_ORDER = 0x8E78;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_TESS_GEN_POINT_MODE = 0x8E79;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_ISOLINES = 0x8E7A;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_FRACTIONAL_ODD = 0x8E7B;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_FRACTIONAL_EVEN = 0x8E7C;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_MAX_PATCH_VERTICES = 0x8E7D;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_MAX_TESS_GEN_LEVEL = 0x8E7E;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E7F;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E80;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS = 0x8E81;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS = 0x8E82;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS = 0x8E83;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_MAX_TESS_PATCH_COMPONENTS = 0x8E84;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS = 0x8E85;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS = 0x8E86;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_TESS_EVALUATION_SHADER = 0x8E87;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_TESS_CONTROL_SHADER = 0x8E88;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS = 0x8E89;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS = 0x8E8A;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_DRAW_INDIRECT_BUFFER = 0x8F3F;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_DRAW_INDIRECT_BUFFER_BINDING = 0x8F43;

#endif
        public const GLenum GL_DOUBLE_MAT2 = 0x8F46;
        public const GLenum GL_DOUBLE_MAT3 = 0x8F47;
        public const GLenum GL_DOUBLE_MAT4 = 0x8F48;
        public const GLenum GL_DOUBLE_MAT2x3 = 0x8F49;
        public const GLenum GL_DOUBLE_MAT2x4 = 0x8F4A;
        public const GLenum GL_DOUBLE_MAT3x2 = 0x8F4B;
        public const GLenum GL_DOUBLE_MAT3x4 = 0x8F4C;
        public const GLenum GL_DOUBLE_MAT4x2 = 0x8F4D;
        public const GLenum GL_DOUBLE_MAT4x3 = 0x8F4E;
        public const GLenum GL_DOUBLE_VEC2 = 0x8FFC;
        public const GLenum GL_DOUBLE_VEC3 = 0x8FFD;
        public const GLenum GL_DOUBLE_VEC4 = 0x8FFE;

#if !GL_ES_VERSION_3_2
        public const GLenum GL_TEXTURE_CUBE_MAP_ARRAY = 0x9009;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_TEXTURE_BINDING_CUBE_MAP_ARRAY = 0x900A;

#endif
        public const GLenum GL_PROXY_TEXTURE_CUBE_MAP_ARRAY = 0x900B;

#if !GL_ES_VERSION_3_2
        public const GLenum GL_SAMPLER_CUBE_MAP_ARRAY = 0x900C;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW = 0x900D;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900E;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900F;

#endif
    }
}
#endif