#if (GL_ARB_half_float_pixel && GL_API)
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HALF_FLOAT_ARB = 0x140B;
#endif
    }
}
#endif