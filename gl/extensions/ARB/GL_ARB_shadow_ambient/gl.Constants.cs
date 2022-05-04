#if (GL_ARB_shadow_ambient && GL_API)
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_COMPARE_FAIL_VALUE_ARB = 0x80BF;
#endif
    }
}
#endif