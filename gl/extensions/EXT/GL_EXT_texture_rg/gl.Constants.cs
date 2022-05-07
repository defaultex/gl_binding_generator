#if (GL_EXT_texture_rg && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_RED_EXT = 0x1903;
        public const GLenum GL_RG_EXT = 0x8227;
        public const GLenum GL_R8_EXT = 0x8229;
        public const GLenum GL_RG8_EXT = 0x822B;
    }
}
#endif