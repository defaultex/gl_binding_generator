#if (GL_MESA_ycbcr_texture && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_UNSIGNED_SHORT_8_8_MESA = 0x85BA;
        public const GLenum GL_UNSIGNED_SHORT_8_8_REV_MESA = 0x85BB;
        public const GLenum GL_YCBCR_MESA = 0x8757;
    }
}
#endif