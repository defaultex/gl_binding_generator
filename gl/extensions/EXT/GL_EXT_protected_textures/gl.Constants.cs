#if (GL_EXT_protected_textures && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_CONTEXT_FLAG_PROTECTED_CONTENT_BIT_EXT = 0x00000010;
        public const GLenum GL_TEXTURE_PROTECTED_EXT = 0x8BFA;
    }
}
#endif