#if (GL_ARB_half_float_vertex && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_HALF_FLOAT = 0x140B;
#endif
    }
}
#endif