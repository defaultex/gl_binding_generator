#if (GL_EXT_texture_object && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_PRIORITY_EXT = 0x8066;
        public const GLenum GL_TEXTURE_RESIDENT_EXT = 0x8067;
        public const GLenum GL_TEXTURE_1D_BINDING_EXT = 0x8068;
        public const GLenum GL_TEXTURE_2D_BINDING_EXT = 0x8069;
        public const GLenum GL_TEXTURE_3D_BINDING_EXT = 0x806A;
    }
}
#endif