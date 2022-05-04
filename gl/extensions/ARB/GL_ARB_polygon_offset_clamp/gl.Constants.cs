#if (GL_ARB_polygon_offset_clamp && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_POLYGON_OFFSET_CLAMP = 0x8E1B;
#endif
    }
}
#endif