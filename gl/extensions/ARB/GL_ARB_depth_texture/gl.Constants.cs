#if (GL_ARB_depth_texture && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_DEPTH_COMPONENT16_ARB = 0x81A5;
        public const GLenum GL_DEPTH_COMPONENT24_ARB = 0x81A6;
        public const GLenum GL_DEPTH_COMPONENT32_ARB = 0x81A7;
        public const GLenum GL_TEXTURE_DEPTH_SIZE_ARB = 0x884A;
        public const GLenum GL_DEPTH_TEXTURE_MODE_ARB = 0x884B;
    }
}
#endif