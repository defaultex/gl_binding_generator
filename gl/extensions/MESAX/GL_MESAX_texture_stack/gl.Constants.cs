#if (GL_MESAX_texture_stack && GL_API)
public partial class mesax { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_1D_STACK_MESAX = 0x8759;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_2D_STACK_MESAX = 0x875A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PROXY_TEXTURE_1D_STACK_MESAX = 0x875B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PROXY_TEXTURE_2D_STACK_MESAX = 0x875C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_1D_STACK_BINDING_MESAX = 0x875D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_2D_STACK_BINDING_MESAX = 0x875E;
#endif
    }
}
#endif