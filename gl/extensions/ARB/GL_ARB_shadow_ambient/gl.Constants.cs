#if (GL_ARB_shadow_ambient && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_COMPARE_FAIL_VALUE_ARB = 0x80BF;
    }
}
#endif