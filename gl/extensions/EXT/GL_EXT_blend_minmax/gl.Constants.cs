#if (GL_EXT_blend_minmax && (!gl || !gles1 || !gles2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_FUNC_ADD_EXT = 0x8006;
        public const GLenum GL_MIN_EXT = 0x8007;
        public const GLenum GL_MAX_EXT = 0x8008;
        public const GLenum GL_BLEND_EQUATION_EXT = 0x8009;
    }
}
#endif