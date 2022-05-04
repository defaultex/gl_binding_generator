#if (GL_ARB_clear_texture && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_CLEAR_TEXTURE = 0x9365;
#endif
    }
}
#endif