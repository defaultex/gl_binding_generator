#if (GL_SUN_convolution_border_modes && GL_API)
public partial class sun { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_WRAP_BORDER_SUN = 0x81D4;
#endif
    }
}
#endif