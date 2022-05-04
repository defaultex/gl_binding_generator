#if (GL_OES_get_program_binary && GLES2_API)
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PROGRAM_BINARY_LENGTH_OES = 0x8741;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_NUM_PROGRAM_BINARY_FORMATS_OES = 0x87FE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PROGRAM_BINARY_FORMATS_OES = 0x87FF;
#endif
    }
}
#endif