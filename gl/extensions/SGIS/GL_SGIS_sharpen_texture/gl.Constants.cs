#if (GL_SGIS_sharpen_texture && GL_API)
public partial class sgis { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LINEAR_SHARPEN_SGIS = 0x80AD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LINEAR_SHARPEN_ALPHA_SGIS = 0x80AE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LINEAR_SHARPEN_COLOR_SGIS = 0x80AF;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHARPEN_TEXTURE_FUNC_POINTS_SGIS = 0x80B0;
#endif
    }
}
#endif