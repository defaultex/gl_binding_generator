#if (GL_EXT_texture_shared_exponent && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_RGB9_E5_EXT = 0x8C3D;
        public const GLenum GL_UNSIGNED_INT_5_9_9_9_REV_EXT = 0x8C3E;
        public const GLenum GL_TEXTURE_SHARED_SIZE_EXT = 0x8C3F;
    }
}
#endif