#if (GL_SGIS_texture_color_mask && GL_API)
public partial class sgis { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_COLOR_WRITEMASK_SGIS = 0x81EF;
#endif
    }
}
#endif