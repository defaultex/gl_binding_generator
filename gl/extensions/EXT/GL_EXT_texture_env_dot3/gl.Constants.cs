#if (GL_EXT_texture_env_dot3 && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DOT3_RGB_EXT = 0x8740;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DOT3_RGBA_EXT = 0x8741;
#endif
    }
}
#endif