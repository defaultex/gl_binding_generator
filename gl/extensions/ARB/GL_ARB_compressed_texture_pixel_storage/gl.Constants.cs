#if (GL_ARB_compressed_texture_pixel_storage && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_UNPACK_COMPRESSED_BLOCK_WIDTH = 0x9127;
        public const GLenum GL_UNPACK_COMPRESSED_BLOCK_HEIGHT = 0x9128;
        public const GLenum GL_UNPACK_COMPRESSED_BLOCK_DEPTH = 0x9129;
        public const GLenum GL_UNPACK_COMPRESSED_BLOCK_SIZE = 0x912A;
        public const GLenum GL_PACK_COMPRESSED_BLOCK_WIDTH = 0x912B;
        public const GLenum GL_PACK_COMPRESSED_BLOCK_HEIGHT = 0x912C;
        public const GLenum GL_PACK_COMPRESSED_BLOCK_DEPTH = 0x912D;
        public const GLenum GL_PACK_COMPRESSED_BLOCK_SIZE = 0x912E;
    }
}
#endif