#if (GL_ANGLE_program_binary && GLES2_API)
public partial class angle { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PROGRAM_BINARY_ANGLE = 0x93A6;
#endif
    }
}
#endif