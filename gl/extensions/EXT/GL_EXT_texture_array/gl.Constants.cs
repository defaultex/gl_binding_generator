#if (GL_EXT_texture_array && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPARE_REF_DEPTH_TO_TEXTURE_EXT = 0x884E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_ARRAY_TEXTURE_LAYERS_EXT = 0x88FF;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_1D_ARRAY_EXT = 0x8C18;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PROXY_TEXTURE_1D_ARRAY_EXT = 0x8C19;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_2D_ARRAY_EXT = 0x8C1A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PROXY_TEXTURE_2D_ARRAY_EXT = 0x8C1B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_BINDING_1D_ARRAY_EXT = 0x8C1C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_BINDING_2D_ARRAY_EXT = 0x8C1D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER_EXT = 0x8CD4;
#endif
    }
}
#endif