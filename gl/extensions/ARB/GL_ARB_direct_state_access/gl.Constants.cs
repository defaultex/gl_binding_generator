#if (GL_ARB_direct_state_access && (GL_API || GLCORE_API))
public partial class glext_arb { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_TARGET = 0x1006;
        public const GLenum GL_TEXTURE_BINDING_1D = 0x8068;
        public const GLenum GL_TEXTURE_BINDING_2D = 0x8069;
        public const GLenum GL_TEXTURE_BINDING_3D = 0x806A;
        public const GLenum GL_QUERY_TARGET = 0x82EA;
        public const GLenum GL_TEXTURE_BINDING_RECTANGLE = 0x84F6;
        public const GLenum GL_TEXTURE_BINDING_CUBE_MAP = 0x8514;
        public const GLenum GL_TEXTURE_BINDING_1D_ARRAY = 0x8C1C;
        public const GLenum GL_TEXTURE_BINDING_2D_ARRAY = 0x8C1D;
        public const GLenum GL_TEXTURE_BINDING_BUFFER = 0x8C2C;
        public const GLenum GL_TEXTURE_BINDING_CUBE_MAP_ARRAY = 0x900A;
        public const GLenum GL_TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104;
        public const GLenum GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105;
    }
}
#endif