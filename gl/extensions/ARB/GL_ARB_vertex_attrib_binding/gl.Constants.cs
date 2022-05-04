#if (GL_ARB_vertex_attrib_binding && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_VERTEX_ATTRIB_BINDING = 0x82D4;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_VERTEX_BINDING_DIVISOR = 0x82D6;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_VERTEX_BINDING_OFFSET = 0x82D7;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_VERTEX_BINDING_STRIDE = 0x82D8;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D9;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_VERTEX_ATTRIB_BINDINGS = 0x82DA;
#endif
    }
}
#endif