#if (GL_ARB_pixel_buffer_object && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_PACK_BUFFER_ARB = 0x88EB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_UNPACK_BUFFER_ARB = 0x88EC;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_PACK_BUFFER_BINDING_ARB = 0x88ED;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_UNPACK_BUFFER_BINDING_ARB = 0x88EF;
#endif
    }
}
#endif