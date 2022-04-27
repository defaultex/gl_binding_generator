#if (GL_ARB_timer_query && (GL_API || GLCORE_API))
public partial class glext_arb { 
    public partial class Constants { 
        public const GLenum GL_TIME_ELAPSED = 0x88BF;
        public const GLenum GL_TIMESTAMP = 0x8E28;
    }
}
#endif