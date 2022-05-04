#if (GL_SGIS_pixel_texture && GL_API)
public partial class sgis { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_TEXTURE_SGIS = 0x8353;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_FRAGMENT_RGB_SOURCE_SGIS = 0x8354;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS = 0x8355;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_GROUP_COLOR_SGIS = 0x8356;
#endif
    }
}
#endif