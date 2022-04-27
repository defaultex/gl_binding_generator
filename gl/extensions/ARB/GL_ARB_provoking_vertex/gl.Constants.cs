#if (GL_ARB_provoking_vertex && (GL_API || GLCORE_API))
public partial class glext_arb { 
    public partial class Constants { 
        public const GLenum GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION = 0x8E4C;
        public const GLenum GL_FIRST_VERTEX_CONVENTION = 0x8E4D;
        public const GLenum GL_LAST_VERTEX_CONVENTION = 0x8E4E;
        public const GLenum GL_PROVOKING_VERTEX = 0x8E4F;
    }
}
#endif