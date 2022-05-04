#if (GL_APPLE_texture_range && GL_API)
public partial class apple { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_RANGE_LENGTH_APPLE = 0x85B7;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_RANGE_POINTER_APPLE = 0x85B8;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_STORAGE_HINT_APPLE = 0x85BC;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_STORAGE_PRIVATE_APPLE = 0x85BD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_STORAGE_CACHED_APPLE = 0x85BE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_STORAGE_SHARED_APPLE = 0x85BF;
#endif
    }
}
#endif