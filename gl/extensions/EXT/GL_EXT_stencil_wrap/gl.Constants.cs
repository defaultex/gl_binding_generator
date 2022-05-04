#if (GL_EXT_stencil_wrap && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INCR_WRAP_EXT = 0x8507;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DECR_WRAP_EXT = 0x8508;
#endif
    }
}
#endif