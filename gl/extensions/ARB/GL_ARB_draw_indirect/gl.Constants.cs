#if (GL_ARB_draw_indirect && (GL_API || GLCORE_API))
public partial class glext_arb { 
    public partial class Constants { 
        public const GLenum GL_DRAW_INDIRECT_BUFFER = 0x8F3F;
        public const GLenum GL_DRAW_INDIRECT_BUFFER_BINDING = 0x8F43;
    }
}
#endif