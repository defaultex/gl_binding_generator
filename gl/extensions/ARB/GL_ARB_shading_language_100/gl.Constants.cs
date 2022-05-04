#if (GL_ARB_shading_language_100 && GL_API)
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADING_LANGUAGE_VERSION_ARB = 0x8B8C;
#endif
    }
}
#endif