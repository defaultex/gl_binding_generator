#if (GL_EXT_separate_shader_objects && (GL_API || GLCORE_API || GLES2_API))
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VERTEX_SHADER_BIT_EXT = 0x00000001;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAGMENT_SHADER_BIT_EXT = 0x00000002;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PROGRAM_SEPARABLE_EXT = 0x8258;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ACTIVE_PROGRAM_EXT = 0x8259;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PROGRAM_PIPELINE_BINDING_EXT = 0x825A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ALL_SHADER_BITS_EXT = 0xFFFFFFFF;
#endif
    }
}
#endif