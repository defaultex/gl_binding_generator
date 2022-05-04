#if (GL_EXT_texture_buffer_object && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_BUFFER_EXT = 0x8C2A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TEXTURE_BUFFER_SIZE_EXT = 0x8C2B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_BINDING_BUFFER_EXT = 0x8C2C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_BUFFER_DATA_STORE_BINDING_EXT = 0x8C2D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_BUFFER_FORMAT_EXT = 0x8C2E;
#endif
    }
}
#endif