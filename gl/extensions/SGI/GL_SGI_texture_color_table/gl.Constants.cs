#if (GL_SGI_texture_color_table && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_COLOR_TABLE_SGI = 0x80BC;
        public const GLenum GL_PROXY_TEXTURE_COLOR_TABLE_SGI = 0x80BD;
    }
}
#endif