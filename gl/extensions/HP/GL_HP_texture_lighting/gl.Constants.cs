#if (GL_HP_texture_lighting && GL_API)
public partial class hp { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_LIGHTING_MODE_HP = 0x8167;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_POST_SPECULAR_HP = 0x8168;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_PRE_SPECULAR_HP = 0x8169;
#endif
    }
}
#endif