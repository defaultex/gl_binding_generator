#if (GL_EXT_occlusion_query_boolean && GLES2_API)
public partial class glext_ext { 
    public partial class Constants { 
        public const GLenum GL_CURRENT_QUERY_EXT = 0x8865;
        public const GLenum GL_QUERY_RESULT_EXT = 0x8866;
        public const GLenum GL_QUERY_RESULT_AVAILABLE_EXT = 0x8867;
        public const GLenum GL_ANY_SAMPLES_PASSED_EXT = 0x8C2F;
        public const GLenum GL_ANY_SAMPLES_PASSED_CONSERVATIVE_EXT = 0x8D6A;
    }
}
#endif