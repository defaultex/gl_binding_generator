#if (GL_EXT_direct_state_access && (GL_API || GLCORE_API))
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PROGRAM_MATRIX_EXT = 0x8E2D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TRANSPOSE_PROGRAM_MATRIX_EXT = 0x8E2E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PROGRAM_MATRIX_STACK_DEPTH_EXT = 0x8E2F;
#endif
    }
}
#endif