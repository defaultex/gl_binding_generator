#if (GL_EXT_texture_rg && GLES2_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RED_EXT = 0x1903;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RG_EXT = 0x8227;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_R8_EXT = 0x8229;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RG8_EXT = 0x822B;
#endif
    }
}
#endif