#if (GL_SGIS_generate_mipmap && GL_API)
public partial class sgis { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_GENERATE_MIPMAP_SGIS = 0x8191;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_GENERATE_MIPMAP_HINT_SGIS = 0x8192;
#endif
    }
}
#endif