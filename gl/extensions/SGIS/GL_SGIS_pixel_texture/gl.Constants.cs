#if (GL_SGIS_pixel_texture && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_PIXEL_TEXTURE_SGIS = 0x8353;
        public const GLenum GL_PIXEL_FRAGMENT_RGB_SOURCE_SGIS = 0x8354;
        public const GLenum GL_PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS = 0x8355;
        public const GLenum GL_PIXEL_GROUP_COLOR_SGIS = 0x8356;
    }
}
#endif