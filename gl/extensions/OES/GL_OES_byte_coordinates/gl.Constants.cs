#if (GL_OES_byte_coordinates && (!gl || !gles1))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_BYTE = 0x1400;
    }
}
#endif