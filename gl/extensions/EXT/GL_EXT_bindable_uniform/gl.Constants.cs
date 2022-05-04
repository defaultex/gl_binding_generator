#if (GL_EXT_bindable_uniform && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_VERTEX_BINDABLE_UNIFORMS_EXT = 0x8DE2;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_FRAGMENT_BINDABLE_UNIFORMS_EXT = 0x8DE3;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_GEOMETRY_BINDABLE_UNIFORMS_EXT = 0x8DE4;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_BINDABLE_UNIFORM_SIZE_EXT = 0x8DED;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNIFORM_BUFFER_EXT = 0x8DEE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNIFORM_BUFFER_BINDING_EXT = 0x8DEF;
#endif
    }
}
#endif