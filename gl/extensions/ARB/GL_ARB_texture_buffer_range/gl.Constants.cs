#if (GL_ARB_texture_buffer_range && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_BUFFER_OFFSET = 0x919D;
        public const GLenum GL_TEXTURE_BUFFER_SIZE = 0x919E;
        public const GLenum GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT = 0x919F;
    }
}
#endif