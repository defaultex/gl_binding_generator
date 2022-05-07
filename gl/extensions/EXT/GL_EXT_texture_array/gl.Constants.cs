#if (GL_EXT_texture_array && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_COMPARE_REF_DEPTH_TO_TEXTURE_EXT = 0x884E;
        public const GLenum GL_MAX_ARRAY_TEXTURE_LAYERS_EXT = 0x88FF;
        public const GLenum GL_TEXTURE_1D_ARRAY_EXT = 0x8C18;
        public const GLenum GL_PROXY_TEXTURE_1D_ARRAY_EXT = 0x8C19;
        public const GLenum GL_TEXTURE_2D_ARRAY_EXT = 0x8C1A;
        public const GLenum GL_PROXY_TEXTURE_2D_ARRAY_EXT = 0x8C1B;
        public const GLenum GL_TEXTURE_BINDING_1D_ARRAY_EXT = 0x8C1C;
        public const GLenum GL_TEXTURE_BINDING_2D_ARRAY_EXT = 0x8C1D;
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER_EXT = 0x8CD4;
    }
}
#endif