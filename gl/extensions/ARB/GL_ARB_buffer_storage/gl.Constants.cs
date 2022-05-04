#if (GL_ARB_buffer_storage && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_MAP_READ_BIT = 0x0001;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_MAP_WRITE_BIT = 0x0002;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_MAP_PERSISTENT_BIT = 0x0040;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_MAP_COHERENT_BIT = 0x0080;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_DYNAMIC_STORAGE_BIT = 0x0100;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_CLIENT_STORAGE_BIT = 0x0200;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT = 0x00004000;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_BUFFER_IMMUTABLE_STORAGE = 0x821F;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_BUFFER_STORAGE_FLAGS = 0x8220;
#endif
    }
}
#endif