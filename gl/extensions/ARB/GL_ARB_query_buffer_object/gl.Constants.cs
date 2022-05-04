#if (GL_ARB_query_buffer_object && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_QUERY_BUFFER_BARRIER_BIT = 0x00008000;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_QUERY_BUFFER = 0x9192;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_QUERY_BUFFER_BINDING = 0x9193;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_QUERY_RESULT_NO_WAIT = 0x9194;
#endif
    }
}
#endif