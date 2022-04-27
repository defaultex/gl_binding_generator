#if (GL_ARB_tessellation_shader && (GL_API || GLCORE_API))
public partial class glext_arb { 
    public partial class Constants { 
        public const GLenum GL_TRIANGLES = 0x0004;
        public const GLenum GL_QUADS = 0x0007;
        public const GLenum GL_PATCHES = 0x000E;
        public const GLenum GL_EQUAL = 0x0202;
        public const GLenum GL_CW = 0x0900;
        public const GLenum GL_CCW = 0x0901;
        public const GLenum GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER = 0x84F0;
        public const GLenum GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x84F1;
        public const GLenum GL_MAX_TESS_CONTROL_INPUT_COMPONENTS = 0x886C;
        public const GLenum GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS = 0x886D;
        public const GLenum GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E1E;
        public const GLenum GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E1F;
        public const GLenum GL_PATCH_VERTICES = 0x8E72;
        public const GLenum GL_PATCH_DEFAULT_INNER_LEVEL = 0x8E73;
        public const GLenum GL_PATCH_DEFAULT_OUTER_LEVEL = 0x8E74;
        public const GLenum GL_TESS_CONTROL_OUTPUT_VERTICES = 0x8E75;
        public const GLenum GL_TESS_GEN_MODE = 0x8E76;
        public const GLenum GL_TESS_GEN_SPACING = 0x8E77;
        public const GLenum GL_TESS_GEN_VERTEX_ORDER = 0x8E78;
        public const GLenum GL_TESS_GEN_POINT_MODE = 0x8E79;
        public const GLenum GL_ISOLINES = 0x8E7A;
        public const GLenum GL_FRACTIONAL_ODD = 0x8E7B;
        public const GLenum GL_FRACTIONAL_EVEN = 0x8E7C;
        public const GLenum GL_MAX_PATCH_VERTICES = 0x8E7D;
        public const GLenum GL_MAX_TESS_GEN_LEVEL = 0x8E7E;
        public const GLenum GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E7F;
        public const GLenum GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E80;
        public const GLenum GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS = 0x8E81;
        public const GLenum GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS = 0x8E82;
        public const GLenum GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS = 0x8E83;
        public const GLenum GL_MAX_TESS_PATCH_COMPONENTS = 0x8E84;
        public const GLenum GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS = 0x8E85;
        public const GLenum GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS = 0x8E86;
        public const GLenum GL_TESS_EVALUATION_SHADER = 0x8E87;
        public const GLenum GL_TESS_CONTROL_SHADER = 0x8E88;
        public const GLenum GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS = 0x8E89;
        public const GLenum GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS = 0x8E8A;
    }
}
#endif