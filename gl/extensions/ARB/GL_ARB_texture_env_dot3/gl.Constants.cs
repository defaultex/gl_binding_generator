#if (GL_ARB_texture_env_dot3 && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_DOT3_RGB_ARB = 0x86AE;
        public const GLenum GL_DOT3_RGBA_ARB = 0x86AF;
    }
}
#endif