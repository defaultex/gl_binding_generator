#if (GL_SGI_texture_color_table && GL_API)
public partial class sgi { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_COLOR_TABLE_SGI = 0x80BC;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PROXY_TEXTURE_COLOR_TABLE_SGI = 0x80BD;
#endif
    }
}
#endif