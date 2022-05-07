#if (GL_SGIS_texture_color_mask && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_COLOR_WRITEMASK_SGIS = 0x81EF;
    }
}
#endif