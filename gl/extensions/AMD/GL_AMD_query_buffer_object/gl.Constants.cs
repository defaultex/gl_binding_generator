#if (GL_AMD_query_buffer_object && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_QUERY_BUFFER_AMD = 0x9192;
        public const GLenum GL_QUERY_BUFFER_BINDING_AMD = 0x9193;
        public const GLenum GL_QUERY_RESULT_NO_WAIT_AMD = 0x9194;
    }
}
#endif