#if (GL_ANGLE_depth_texture && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_UNSIGNED_SHORT = 0x1403;
        public const GLenum GL_UNSIGNED_INT = 0x1405;
        public const GLenum GL_DEPTH_COMPONENT = 0x1902;
        public const GLenum GL_DEPTH_COMPONENT16 = 0x81A5;
        public const GLenum GL_DEPTH_COMPONENT32_OES = 0x81A7;
        public const GLenum GL_DEPTH_STENCIL_OES = 0x84F9;
        public const GLenum GL_UNSIGNED_INT_24_8_OES = 0x84FA;
        public const GLenum GL_DEPTH24_STENCIL8_OES = 0x88F0;
    }
}
#endif