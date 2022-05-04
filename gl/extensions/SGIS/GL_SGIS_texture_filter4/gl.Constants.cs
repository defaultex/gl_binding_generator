#if (GL_SGIS_texture_filter4 && GL_API)
public partial class sgis { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FILTER4_SGIS = 0x8146;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_FILTER4_SIZE_SGIS = 0x8147;
#endif
    }
}
#endif