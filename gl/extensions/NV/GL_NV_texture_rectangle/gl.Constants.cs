#if (GL_NV_texture_rectangle && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_RECTANGLE_NV = 0x84F5;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_BINDING_RECTANGLE_NV = 0x84F6;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PROXY_TEXTURE_RECTANGLE_NV = 0x84F7;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_RECTANGLE_TEXTURE_SIZE_NV = 0x84F8;
#endif
    }
}
#endif