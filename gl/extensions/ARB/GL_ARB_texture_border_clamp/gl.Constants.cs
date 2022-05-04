#if (GL_ARB_texture_border_clamp && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CLAMP_TO_BORDER_ARB = 0x812D;
#endif
    }
}
#endif