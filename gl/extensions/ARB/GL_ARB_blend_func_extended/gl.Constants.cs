#if (GL_ARB_blend_func_extended && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_SRC1_ALPHA = 0x8589;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_SRC1_COLOR = 0x88F9;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_ONE_MINUS_SRC1_COLOR = 0x88FA;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_ONE_MINUS_SRC1_ALPHA = 0x88FB;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_DUAL_SOURCE_DRAW_BUFFERS = 0x88FC;
#endif
    }
}
#endif