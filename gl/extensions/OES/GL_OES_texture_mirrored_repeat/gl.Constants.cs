#if (GL_OES_texture_mirrored_repeat && GLES1_API)
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MIRRORED_REPEAT_OES = 0x8370;
#endif
    }
}
#endif