#if (GL_NV_shader_buffer_load && (GL_API || GLCORE_API))
public partial class glext_nv { 
    public partial class Constants { 
        public const GLenum GL_BUFFER_GPU_ADDRESS_NV = 0x8F1D;
        public const GLenum GL_GPU_ADDRESS_NV = 0x8F34;
        public const GLenum GL_MAX_SHADER_BUFFER_ADDRESS_NV = 0x8F35;
    }
}
#endif