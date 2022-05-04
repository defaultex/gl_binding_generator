#if (GL_EXT_buffer_storage && GLES2_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_MAP_READ_BIT = 0x0001;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_MAP_WRITE_BIT = 0x0002;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAP_PERSISTENT_BIT_EXT = 0x0040;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAP_COHERENT_BIT_EXT = 0x0080;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DYNAMIC_STORAGE_BIT_EXT = 0x0100;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CLIENT_STORAGE_BIT_EXT = 0x0200;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT_EXT = 0x00004000;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BUFFER_IMMUTABLE_STORAGE_EXT = 0x821F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BUFFER_STORAGE_FLAGS_EXT = 0x8220;
#endif
    }
}
#endif