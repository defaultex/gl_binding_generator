#if (GL_NV_vdpau_interop && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SURFACE_STATE_NV = 0x86EB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SURFACE_REGISTERED_NV = 0x86FD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SURFACE_MAPPED_NV = 0x8700;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_WRITE_DISCARD_NV = 0x88BE;
#endif
    }
}
#endif