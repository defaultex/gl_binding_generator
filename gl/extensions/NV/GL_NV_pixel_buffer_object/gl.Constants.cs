#if (GL_NV_pixel_buffer_object && GLES2_API)
public partial class glext_nv { 
    public partial class Constants { 
        public const GLenum GL_PIXEL_PACK_BUFFER_NV = 0x88EB;
        public const GLenum GL_PIXEL_UNPACK_BUFFER_NV = 0x88EC;
        public const GLenum GL_PIXEL_PACK_BUFFER_BINDING_NV = 0x88ED;
        public const GLenum GL_PIXEL_UNPACK_BUFFER_BINDING_NV = 0x88EF;
    }
}
#endif