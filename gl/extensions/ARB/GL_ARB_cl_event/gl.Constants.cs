#if (GL_ARB_cl_event && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SYNC_CL_EVENT_ARB = 0x8240;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SYNC_CL_EVENT_COMPLETE_ARB = 0x8241;
#endif
    }
}
#endif