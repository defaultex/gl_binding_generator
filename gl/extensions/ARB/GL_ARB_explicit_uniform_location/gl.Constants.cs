#if (GL_ARB_explicit_uniform_location && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_MAX_UNIFORM_LOCATIONS = 0x826E;
    }
}
#endif