#if (GL_NV_parameter_buffer_object && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_MAX_PROGRAM_PARAMETER_BUFFER_BINDINGS_NV = 0x8DA0;
        public const GLenum GL_MAX_PROGRAM_PARAMETER_BUFFER_SIZE_NV = 0x8DA1;
        public const GLenum GL_VERTEX_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA2;
        public const GLenum GL_GEOMETRY_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA3;
        public const GLenum GL_FRAGMENT_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA4;
    }
}
#endif