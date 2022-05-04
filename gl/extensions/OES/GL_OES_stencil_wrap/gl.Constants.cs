#if (GL_OES_stencil_wrap && GLES1_API)
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INCR_WRAP_OES = 0x8507;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DECR_WRAP_OES = 0x8508;
#endif
    }
}
#endif