#if (GL_APPLE_flush_buffer_range && GL_API)
public partial class apple { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BUFFER_SERIALIZED_MODIFY_APPLE = 0x8A12;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BUFFER_FLUSHING_UNMAP_APPLE = 0x8A13;
#endif
    }
}
#endif