#if (GL_IMG_program_binary && GLES2_API)
public partial class img { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SGX_PROGRAM_BINARY_IMG = 0x9130;
#endif
    }
}
#endif