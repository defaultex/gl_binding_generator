#if (GL_ARB_pipeline_statistics_query && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_VERTICES_SUBMITTED_ARB = 0x82EE;
        public const GLenum GL_PRIMITIVES_SUBMITTED_ARB = 0x82EF;
        public const GLenum GL_VERTEX_SHADER_INVOCATIONS_ARB = 0x82F0;
        public const GLenum GL_TESS_CONTROL_SHADER_PATCHES_ARB = 0x82F1;
        public const GLenum GL_TESS_EVALUATION_SHADER_INVOCATIONS_ARB = 0x82F2;
        public const GLenum GL_GEOMETRY_SHADER_PRIMITIVES_EMITTED_ARB = 0x82F3;
        public const GLenum GL_FRAGMENT_SHADER_INVOCATIONS_ARB = 0x82F4;
        public const GLenum GL_COMPUTE_SHADER_INVOCATIONS_ARB = 0x82F5;
        public const GLenum GL_CLIPPING_INPUT_PRIMITIVES_ARB = 0x82F6;
        public const GLenum GL_CLIPPING_OUTPUT_PRIMITIVES_ARB = 0x82F7;
        public const GLenum GL_GEOMETRY_SHADER_INVOCATIONS = 0x887F;
    }
}
#endif