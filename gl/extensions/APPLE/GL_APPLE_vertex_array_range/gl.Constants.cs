#if (GL_APPLE_vertex_array_range && GL_API)
public partial class apple { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VERTEX_ARRAY_RANGE_APPLE = 0x851D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VERTEX_ARRAY_RANGE_LENGTH_APPLE = 0x851E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VERTEX_ARRAY_STORAGE_HINT_APPLE = 0x851F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VERTEX_ARRAY_RANGE_POINTER_APPLE = 0x8521;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_STORAGE_CLIENT_APPLE = 0x85B4;
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