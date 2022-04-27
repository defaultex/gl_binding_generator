#if (GL_ARB_query_buffer_object && (GL_API || GLCORE_API))
public partial class glext_arb { 
    public partial class Constants { 
        public const GLbitfield GL_QUERY_BUFFER_BARRIER_BIT = 0x00008000;
        public const GLenum GL_QUERY_BUFFER = 0x9192;
        public const GLenum GL_QUERY_BUFFER_BINDING = 0x9193;
        public const GLenum GL_QUERY_RESULT_NO_WAIT = 0x9194;
    }
}
#endif