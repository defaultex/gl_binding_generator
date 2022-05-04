#if (GL_ARB_shadow && GL_API)
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_COMPARE_MODE_ARB = 0x884C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_COMPARE_FUNC_ARB = 0x884D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPARE_R_TO_TEXTURE_ARB = 0x884E;
#endif
    }
}
#endif