#if (GL_NV_texture_rectangle && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_RECTANGLE_NV = 0x84F5;
        public const GLenum GL_TEXTURE_BINDING_RECTANGLE_NV = 0x84F6;
        public const GLenum GL_PROXY_TEXTURE_RECTANGLE_NV = 0x84F7;
        public const GLenum GL_MAX_RECTANGLE_TEXTURE_SIZE_NV = 0x84F8;
    }
}
#endif