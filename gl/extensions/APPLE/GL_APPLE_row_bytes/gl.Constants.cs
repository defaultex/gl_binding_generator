#if (GL_APPLE_row_bytes && GL_API)
public partial class apple { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PACK_ROW_BYTES_APPLE = 0x8A15;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNPACK_ROW_BYTES_APPLE = 0x8A16;
#endif
    }
}
#endif