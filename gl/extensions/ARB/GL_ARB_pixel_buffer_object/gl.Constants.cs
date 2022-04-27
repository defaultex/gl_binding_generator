#if (GL_ARB_pixel_buffer_object && (GL_API || GLCORE_API))
public partial class glext_arb { 
    public partial class Constants { 
        public const GLenum GL_PIXEL_PACK_BUFFER_ARB = 0x88EB;
        public const GLenum GL_PIXEL_UNPACK_BUFFER_ARB = 0x88EC;
        public const GLenum GL_PIXEL_PACK_BUFFER_BINDING_ARB = 0x88ED;
        public const GLenum GL_PIXEL_UNPACK_BUFFER_BINDING_ARB = 0x88EF;
    }
}
#endif