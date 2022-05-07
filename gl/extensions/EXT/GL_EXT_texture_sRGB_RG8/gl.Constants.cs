#if (GL_EXT_texture_sRGB_RG8 && (!gles2 || !gl || !glcore))
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_SRG8_EXT = 0x8FBE;
    }
}
#endif