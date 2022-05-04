#if (GL_OES_packed_depth_stencil && (GLES1_API || GLES2_API))
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPTH_STENCIL_OES = 0x84F9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT_24_8_OES = 0x84FA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPTH24_STENCIL8_OES = 0x88F0;
#endif
    }
}
#endif