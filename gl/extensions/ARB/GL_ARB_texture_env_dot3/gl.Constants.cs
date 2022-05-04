#if (GL_ARB_texture_env_dot3 && GL_API)
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DOT3_RGB_ARB = 0x86AE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DOT3_RGBA_ARB = 0x86AF;
#endif
    }
}
#endif