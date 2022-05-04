#if (GL_NV_texture_border_clamp && GLES2_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_BORDER_COLOR_NV = 0x1004;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CLAMP_TO_BORDER_NV = 0x812D;
#endif
    }
}
#endif