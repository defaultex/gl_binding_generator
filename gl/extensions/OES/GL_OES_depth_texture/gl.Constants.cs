#if (GL_OES_depth_texture && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_UNSIGNED_SHORT = 0x1403;
        public const GLenum GL_UNSIGNED_INT = 0x1405;
        public const GLenum GL_DEPTH_COMPONENT = 0x1902;
    }
}
#endif