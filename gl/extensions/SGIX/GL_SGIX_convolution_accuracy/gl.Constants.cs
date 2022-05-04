#if (GL_SGIX_convolution_accuracy && GL_API)
public partial class sgix { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONVOLUTION_HINT_SGIX = 0x8316;
#endif
    }
}
#endif