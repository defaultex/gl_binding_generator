#if (GL_ARB_shader_subroutine && (GL_API || GLCORE_API))
public partial class glext_arb { 
    public partial class Constants { 
        public const GLenum GL_UNIFORM_SIZE = 0x8A38;
        public const GLenum GL_UNIFORM_NAME_LENGTH = 0x8A39;
        public const GLenum GL_ACTIVE_SUBROUTINES = 0x8DE5;
        public const GLenum GL_ACTIVE_SUBROUTINE_UNIFORMS = 0x8DE6;
        public const GLenum GL_MAX_SUBROUTINES = 0x8DE7;
        public const GLenum GL_MAX_SUBROUTINE_UNIFORM_LOCATIONS = 0x8DE8;
        public const GLenum GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS = 0x8E47;
        public const GLenum GL_ACTIVE_SUBROUTINE_MAX_LENGTH = 0x8E48;
        public const GLenum GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH = 0x8E49;
        public const GLenum GL_NUM_COMPATIBLE_SUBROUTINES = 0x8E4A;
        public const GLenum GL_COMPATIBLE_SUBROUTINES = 0x8E4B;
    }
}
#endif