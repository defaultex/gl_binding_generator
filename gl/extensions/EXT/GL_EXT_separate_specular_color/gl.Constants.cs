#if (GL_EXT_separate_specular_color && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LIGHT_MODEL_COLOR_CONTROL_EXT = 0x81F8;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SINGLE_COLOR_EXT = 0x81F9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SEPARATE_SPECULAR_COLOR_EXT = 0x81FA;
#endif
    }
}
#endif