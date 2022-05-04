#if (GL_NV_deep_texture3D && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_DEEP_3D_TEXTURE_WIDTH_HEIGHT_NV = 0x90D0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_DEEP_3D_TEXTURE_DEPTH_NV = 0x90D1;
#endif
    }
}
#endif