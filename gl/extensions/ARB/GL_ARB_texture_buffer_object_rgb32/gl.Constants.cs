#if (GL_ARB_texture_buffer_object_rgb32 && (GL_API || GLCORE_API))
public partial class glext_arb { 
    public partial class Constants { 
        public const GLenum GL_RGB32F = 0x8815;
        public const GLenum GL_RGB32UI = 0x8D71;
        public const GLenum GL_RGB32I = 0x8D83;
    }
}
#endif