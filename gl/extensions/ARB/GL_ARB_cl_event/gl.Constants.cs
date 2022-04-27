#if (GL_ARB_cl_event && (GL_API || GLCORE_API))
public partial class glext_arb { 
    public partial class Constants { 
        public const GLenum GL_SYNC_CL_EVENT_ARB = 0x8240;
        public const GLenum GL_SYNC_CL_EVENT_COMPLETE_ARB = 0x8241;
    }
}
#endif