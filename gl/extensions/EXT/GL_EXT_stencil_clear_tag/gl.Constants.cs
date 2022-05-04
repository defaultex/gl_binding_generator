#if (GL_EXT_stencil_clear_tag && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_STENCIL_TAG_BITS_EXT = 0x88F2;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_STENCIL_CLEAR_TAG_VALUE_EXT = 0x88F3;
#endif
    }
}
#endif