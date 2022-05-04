#if (GL_ARM_mali_program_binary && GLES2_API)
public partial class arm { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MALI_PROGRAM_BINARY_ARM = 0x8F61;
#endif
    }
}
#endif