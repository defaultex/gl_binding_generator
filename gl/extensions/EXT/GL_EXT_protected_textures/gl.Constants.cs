#if (GL_EXT_protected_textures && GLES2_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONTEXT_FLAG_PROTECTED_CONTENT_BIT_EXT = 0x00000010;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_PROTECTED_EXT = 0x8BFA;
#endif
    }
}
#endif