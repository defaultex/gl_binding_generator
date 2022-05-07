#if (GL_MESAX_texture_stack && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_1D_STACK_MESAX = 0x8759;
        public const GLenum GL_TEXTURE_2D_STACK_MESAX = 0x875A;
        public const GLenum GL_PROXY_TEXTURE_1D_STACK_MESAX = 0x875B;
        public const GLenum GL_PROXY_TEXTURE_2D_STACK_MESAX = 0x875C;
        public const GLenum GL_TEXTURE_1D_STACK_BINDING_MESAX = 0x875D;
        public const GLenum GL_TEXTURE_2D_STACK_BINDING_MESAX = 0x875E;
    }
}
#endif