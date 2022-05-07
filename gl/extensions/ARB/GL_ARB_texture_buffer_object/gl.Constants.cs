#if (GL_ARB_texture_buffer_object && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_BUFFER_ARB = 0x8C2A;
        public const GLenum GL_MAX_TEXTURE_BUFFER_SIZE_ARB = 0x8C2B;
        public const GLenum GL_TEXTURE_BINDING_BUFFER_ARB = 0x8C2C;
        public const GLenum GL_TEXTURE_BUFFER_DATA_STORE_BINDING_ARB = 0x8C2D;
        public const GLenum GL_TEXTURE_BUFFER_FORMAT_ARB = 0x8C2E;
    }
}
#endif