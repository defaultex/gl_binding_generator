#if (GL_OES_stencil8 && GLES1_API)
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_STENCIL_INDEX8_OES = 0x8D48;
#endif
    }
}
#endif