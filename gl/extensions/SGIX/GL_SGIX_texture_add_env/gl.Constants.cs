#if (GL_SGIX_texture_add_env && GL_API)
public partial class sgix { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_ENV_BIAS_SGIX = 0x80BE;
#endif
    }
}
#endif