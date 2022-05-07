#if (GL_EXT_separate_shader_objects && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_VERTEX_SHADER_BIT_EXT = 0x00000001;
        public const GLenum GL_FRAGMENT_SHADER_BIT_EXT = 0x00000002;
        public const GLenum GL_PROGRAM_SEPARABLE_EXT = 0x8258;
        public const GLenum GL_ACTIVE_PROGRAM_EXT = 0x8259;
        public const GLenum GL_PROGRAM_PIPELINE_BINDING_EXT = 0x825A;
        public const GLenum GL_ALL_SHADER_BITS_EXT = 0xFFFFFFFF;
    }
}
#endif