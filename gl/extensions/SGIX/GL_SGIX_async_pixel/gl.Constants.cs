#if (GL_SGIX_async_pixel && GL_API)
public partial class sgix { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ASYNC_TEX_IMAGE_SGIX = 0x835C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ASYNC_DRAW_PIXELS_SGIX = 0x835D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ASYNC_READ_PIXELS_SGIX = 0x835E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_ASYNC_TEX_IMAGE_SGIX = 0x835F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_ASYNC_DRAW_PIXELS_SGIX = 0x8360;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_ASYNC_READ_PIXELS_SGIX = 0x8361;
#endif
    }
}
#endif