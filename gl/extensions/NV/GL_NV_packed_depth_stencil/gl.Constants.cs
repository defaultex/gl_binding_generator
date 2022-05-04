#if (GL_NV_packed_depth_stencil && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPTH_STENCIL_NV = 0x84F9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT_24_8_NV = 0x84FA;
#endif
    }
}
#endif