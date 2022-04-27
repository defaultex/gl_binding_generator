#if (GL_EXT_bindable_uniform && GL_API)
public partial class glext_ext { 
    public partial class Constants { 
        public const GLenum GL_MAX_VERTEX_BINDABLE_UNIFORMS_EXT = 0x8DE2;
        public const GLenum GL_MAX_FRAGMENT_BINDABLE_UNIFORMS_EXT = 0x8DE3;
        public const GLenum GL_MAX_GEOMETRY_BINDABLE_UNIFORMS_EXT = 0x8DE4;
        public const GLenum GL_MAX_BINDABLE_UNIFORM_SIZE_EXT = 0x8DED;
        public const GLenum GL_UNIFORM_BUFFER_EXT = 0x8DEE;
        public const GLenum GL_UNIFORM_BUFFER_BINDING_EXT = 0x8DEF;
    }
}
#endif