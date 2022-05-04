#if (GL_ATI_texture_env_combine3 && GL_API)
public partial class ati { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MODULATE_ADD_ATI = 0x8744;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MODULATE_SIGNED_ADD_ATI = 0x8745;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MODULATE_SUBTRACT_ATI = 0x8746;
#endif
    }
}
#endif