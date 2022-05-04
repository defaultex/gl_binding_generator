#if (GL_ARB_map_buffer_range && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_MAP_READ_BIT = 0x0001;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_MAP_WRITE_BIT = 0x0002;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_MAP_INVALIDATE_RANGE_BIT = 0x0004;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_MAP_INVALIDATE_BUFFER_BIT = 0x0008;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_MAP_FLUSH_EXPLICIT_BIT = 0x0010;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_MAP_UNSYNCHRONIZED_BIT = 0x0020;
#endif
    }
}
#endif