#if (GL_EXT_texture_buffer && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_BUFFER_BINDING_EXT = 0x8C2A;
        public const GLenum GL_TEXTURE_BUFFER_EXT = 0x8C2A;
        public const GLenum GL_MAX_TEXTURE_BUFFER_SIZE_EXT = 0x8C2B;
        public const GLenum GL_TEXTURE_BINDING_BUFFER_EXT = 0x8C2C;
        public const GLenum GL_TEXTURE_BUFFER_DATA_STORE_BINDING_EXT = 0x8C2D;
        public const GLenum GL_SAMPLER_BUFFER_EXT = 0x8DC2;
        public const GLenum GL_INT_SAMPLER_BUFFER_EXT = 0x8DD0;
        public const GLenum GL_UNSIGNED_INT_SAMPLER_BUFFER_EXT = 0x8DD8;
        public const GLenum GL_IMAGE_BUFFER_EXT = 0x9051;
        public const GLenum GL_INT_IMAGE_BUFFER_EXT = 0x905C;
        public const GLenum GL_UNSIGNED_INT_IMAGE_BUFFER_EXT = 0x9067;
        public const GLenum GL_TEXTURE_BUFFER_OFFSET_EXT = 0x919D;
        public const GLenum GL_TEXTURE_BUFFER_SIZE_EXT = 0x919E;
        public const GLenum GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT_EXT = 0x919F;
    }
}
#endif