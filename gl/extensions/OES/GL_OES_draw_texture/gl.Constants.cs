#if (GL_OES_draw_texture && GLES1_API)
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_CROP_RECT_OES = 0x8B9D;
#endif
    }
}
#endif