#if (GL_ARB_fragment_shader && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_FRAGMENT_SHADER_ARB = 0x8B30;
        public const GLenum GL_MAX_FRAGMENT_UNIFORM_COMPONENTS_ARB = 0x8B49;
        public const GLenum GL_FRAGMENT_SHADER_DERIVATIVE_HINT_ARB = 0x8B8B;
    }
}
#endif