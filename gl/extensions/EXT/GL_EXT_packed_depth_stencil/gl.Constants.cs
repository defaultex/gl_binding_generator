#if (GL_EXT_packed_depth_stencil && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPTH_STENCIL_EXT = 0x84F9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT_24_8_EXT = 0x84FA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPTH24_STENCIL8_EXT = 0x88F0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_STENCIL_SIZE_EXT = 0x88F1;
#endif
    }
}
#endif