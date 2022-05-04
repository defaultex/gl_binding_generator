#if (GL_SGIS_texture_border_clamp && GL_API)
public partial class sgis { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CLAMP_TO_BORDER_SGIS = 0x812D;
#endif
    }
}
#endif