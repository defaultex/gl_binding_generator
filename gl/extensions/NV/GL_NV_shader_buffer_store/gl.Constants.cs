#if (GL_NV_shader_buffer_store && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_SHADER_GLOBAL_ACCESS_BARRIER_BIT_NV = 0x00000010;
        public const GLenum GL_WRITE_ONLY = 0x88B9;
        public const GLenum GL_READ_WRITE = 0x88BA;
    }
}
#endif