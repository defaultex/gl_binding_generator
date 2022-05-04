#if (GL_NV_pixel_buffer_object && GLES2_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_PACK_BUFFER_NV = 0x88EB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_UNPACK_BUFFER_NV = 0x88EC;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_PACK_BUFFER_BINDING_NV = 0x88ED;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_UNPACK_BUFFER_BINDING_NV = 0x88EF;
#endif
    }
}
#endif