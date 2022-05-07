#if (GL_EXT_pixel_buffer_object && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_PIXEL_PACK_BUFFER_EXT = 0x88EB;
        public const GLenum GL_PIXEL_UNPACK_BUFFER_EXT = 0x88EC;
        public const GLenum GL_PIXEL_PACK_BUFFER_BINDING_EXT = 0x88ED;
        public const GLenum GL_PIXEL_UNPACK_BUFFER_BINDING_EXT = 0x88EF;
    }
}
#endif