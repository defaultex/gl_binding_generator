#if (GL_SGIX_async && GL_API)
public partial class sgix { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ASYNC_MARKER_SGIX = 0x8329;
#endif
    }
}
#endif