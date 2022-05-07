#if (GL_APPLE_flush_buffer_range && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_BUFFER_SERIALIZED_MODIFY_APPLE = 0x8A12;
        public const GLenum GL_BUFFER_FLUSHING_UNMAP_APPLE = 0x8A13;
    }
}
#endif