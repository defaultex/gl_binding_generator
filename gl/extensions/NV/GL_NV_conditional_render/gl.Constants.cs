#if (GL_NV_conditional_render && (GL_API || GLCORE_API || GLES2_API))
public partial class glext_nv { 
    public partial class Constants { 
        public const GLenum GL_QUERY_WAIT_NV = 0x8E13;
        public const GLenum GL_QUERY_NO_WAIT_NV = 0x8E14;
        public const GLenum GL_QUERY_BY_REGION_WAIT_NV = 0x8E15;
        public const GLenum GL_QUERY_BY_REGION_NO_WAIT_NV = 0x8E16;
    }
}
#endif