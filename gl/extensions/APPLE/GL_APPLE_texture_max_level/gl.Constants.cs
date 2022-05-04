#if (GL_APPLE_texture_max_level && (GLES1_API || GLES2_API))
public partial class apple { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_MAX_LEVEL_APPLE = 0x813D;
#endif
    }
}
#endif