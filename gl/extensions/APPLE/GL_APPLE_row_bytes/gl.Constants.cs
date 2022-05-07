#if (GL_APPLE_row_bytes && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_PACK_ROW_BYTES_APPLE = 0x8A15;
        public const GLenum GL_UNPACK_ROW_BYTES_APPLE = 0x8A16;
    }
}
#endif