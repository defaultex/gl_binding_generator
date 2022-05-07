#if (GL_EXT_blend_subtract && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_FUNC_SUBTRACT_EXT = 0x800A;
        public const GLenum GL_FUNC_REVERSE_SUBTRACT_EXT = 0x800B;
    }
}
#endif