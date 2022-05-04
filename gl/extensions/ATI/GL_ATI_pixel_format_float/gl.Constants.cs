#if (GL_ATI_pixel_format_float && GL_API)
public partial class ati { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGBA_FLOAT_MODE_ATI = 0x8820;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_CLEAR_UNCLAMPED_VALUE_ATI = 0x8835;
#endif
    }
}
#endif