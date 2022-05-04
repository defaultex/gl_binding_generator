#if (GL_ARB_draw_indirect && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DRAW_INDIRECT_BUFFER = 0x8F3F;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DRAW_INDIRECT_BUFFER_BINDING = 0x8F43;
#endif
    }
}
#endif