#if (GL_EXT_packed_float && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_R11F_G11F_B10F_EXT = 0x8C3A;
        public const GLenum GL_UNSIGNED_INT_10F_11F_11F_REV_EXT = 0x8C3B;
        public const GLenum GL_RGBA_SIGNED_COMPONENTS_EXT = 0x8C3C;
    }
}
#endif