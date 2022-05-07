#if (GL_SGIX_ycrcb && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_YCRCB_422_SGIX = 0x81BB;
        public const GLenum GL_YCRCB_444_SGIX = 0x81BC;
    }
}
#endif