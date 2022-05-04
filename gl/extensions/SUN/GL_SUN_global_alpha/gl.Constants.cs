#if (GL_SUN_global_alpha && GL_API)
public partial class sun { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_GLOBAL_ALPHA_SUN = 0x81D9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_GLOBAL_ALPHA_FACTOR_SUN = 0x81DA;
#endif
    }
}
#endif