#if (GL_NV_coverage_sample && GLES2_API)
public partial class glext_nv { 
    public partial class Constants { 
        public const GLenum GL_COVERAGE_BUFFER_BIT_NV = 0x00008000;
        public const GLenum GL_COVERAGE_COMPONENT_NV = 0x8ED0;
        public const GLenum GL_COVERAGE_COMPONENT4_NV = 0x8ED1;
        public const GLenum GL_COVERAGE_ATTACHMENT_NV = 0x8ED2;
        public const GLenum GL_COVERAGE_BUFFERS_NV = 0x8ED3;
        public const GLenum GL_COVERAGE_SAMPLES_NV = 0x8ED4;
        public const GLenum GL_COVERAGE_ALL_FRAGMENTS_NV = 0x8ED5;
        public const GLenum GL_COVERAGE_EDGE_FRAGMENTS_NV = 0x8ED6;
        public const GLenum GL_COVERAGE_AUTOMATIC_NV = 0x8ED7;
    }
}
#endif