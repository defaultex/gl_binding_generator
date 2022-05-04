#if (GL_ANGLE_translated_shader_source && GLES2_API)
public partial class angle { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TRANSLATED_SHADER_SOURCE_LENGTH_ANGLE = 0x93A0;
#endif
    }
}
#endif