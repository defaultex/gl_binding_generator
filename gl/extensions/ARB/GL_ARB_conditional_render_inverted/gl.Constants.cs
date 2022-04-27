#if (GL_ARB_conditional_render_inverted && (GL_API || GLCORE_API))
public partial class glext_arb { 
    public partial class Constants { 
        public const GLenum GL_QUERY_WAIT_INVERTED = 0x8E17;
        public const GLenum GL_QUERY_NO_WAIT_INVERTED = 0x8E18;
        public const GLenum GL_QUERY_BY_REGION_WAIT_INVERTED = 0x8E19;
        public const GLenum GL_QUERY_BY_REGION_NO_WAIT_INVERTED = 0x8E1A;
    }
}
#endif