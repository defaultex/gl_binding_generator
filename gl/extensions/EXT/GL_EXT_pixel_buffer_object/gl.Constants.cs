#if (GL_EXT_pixel_buffer_object && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_PACK_BUFFER_EXT = 0x88EB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_UNPACK_BUFFER_EXT = 0x88EC;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_PACK_BUFFER_BINDING_EXT = 0x88ED;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_UNPACK_BUFFER_BINDING_EXT = 0x88EF;
#endif
    }
}
#endif