#if (GL_EXT_map_buffer_range && (GLES1_API || GLES2_API))
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAP_READ_BIT_EXT = 0x0001;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAP_WRITE_BIT_EXT = 0x0002;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAP_INVALIDATE_RANGE_BIT_EXT = 0x0004;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAP_INVALIDATE_BUFFER_BIT_EXT = 0x0008;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAP_FLUSH_EXPLICIT_BIT_EXT = 0x0010;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAP_UNSYNCHRONIZED_BIT_EXT = 0x0020;
#endif
    }
}
#endif