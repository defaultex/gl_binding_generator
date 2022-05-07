#if (GL_EXT_texture_env_dot3 && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_DOT3_RGB_EXT = 0x8740;
        public const GLenum GL_DOT3_RGBA_EXT = 0x8741;
    }
}
#endif