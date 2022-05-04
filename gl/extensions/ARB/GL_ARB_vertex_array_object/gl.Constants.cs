#if (GL_ARB_vertex_array_object && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_VERTEX_ARRAY_BINDING = 0x85B5;
#endif
    }
}
#endif