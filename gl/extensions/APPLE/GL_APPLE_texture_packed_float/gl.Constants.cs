#if (GL_APPLE_texture_packed_float && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_R11F_G11F_B10F_APPLE = 0x8C3A;
        public const GLenum GL_UNSIGNED_INT_10F_11F_11F_REV_APPLE = 0x8C3B;
        public const GLenum GL_RGB9_E5_APPLE = 0x8C3D;
        public const GLenum GL_UNSIGNED_INT_5_9_9_9_REV_APPLE = 0x8C3E;
    }
}
#endif