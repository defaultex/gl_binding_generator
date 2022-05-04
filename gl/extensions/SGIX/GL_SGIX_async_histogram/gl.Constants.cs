#if (GL_SGIX_async_histogram && GL_API)
public partial class sgix { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ASYNC_HISTOGRAM_SGIX = 0x832C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_ASYNC_HISTOGRAM_SGIX = 0x832D;
#endif
    }
}
#endif