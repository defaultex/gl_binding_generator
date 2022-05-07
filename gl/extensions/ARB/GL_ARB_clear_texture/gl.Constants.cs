#if (GL_ARB_clear_texture && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_CLEAR_TEXTURE = 0x9365;
    }
}
#endif