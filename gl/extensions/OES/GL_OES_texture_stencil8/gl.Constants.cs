#if (GL_OES_texture_stencil8 && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_STENCIL_INDEX_OES = 0x1901;
        public const GLenum GL_STENCIL_INDEX8_OES = 0x8D48;
    }
}
#endif