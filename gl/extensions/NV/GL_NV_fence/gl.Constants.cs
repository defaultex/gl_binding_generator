#if (GL_NV_fence && (GL_API || GLES1_API || GLES2_API))
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ALL_COMPLETED_NV = 0x84F2;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FENCE_STATUS_NV = 0x84F3;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FENCE_CONDITION_NV = 0x84F4;
#endif
    }
}
#endif