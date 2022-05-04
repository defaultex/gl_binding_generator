#if (GL_ARB_transform_feedback3 && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_TRANSFORM_FEEDBACK_BUFFERS = 0x8E70;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_VERTEX_STREAMS = 0x8E71;
#endif
    }
}
#endif