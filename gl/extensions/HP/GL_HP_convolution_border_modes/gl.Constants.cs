#if (GL_HP_convolution_border_modes && GL_API)
public partial class hp { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_IGNORE_BORDER_HP = 0x8150;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONSTANT_BORDER_HP = 0x8151;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_REPLICATE_BORDER_HP = 0x8153;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONVOLUTION_BORDER_COLOR_HP = 0x8154;
#endif
    }
}
#endif