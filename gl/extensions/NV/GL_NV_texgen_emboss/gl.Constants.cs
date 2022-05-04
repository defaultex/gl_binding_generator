#if (GL_NV_texgen_emboss && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_EMBOSS_LIGHT_NV = 0x855D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_EMBOSS_CONSTANT_NV = 0x855E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_EMBOSS_MAP_NV = 0x855F;
#endif
    }
}
#endif