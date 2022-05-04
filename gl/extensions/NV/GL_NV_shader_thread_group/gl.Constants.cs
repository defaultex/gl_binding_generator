#if (GL_NV_shader_thread_group && (GL_API || GLCORE_API))
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_WARP_SIZE_NV = 0x9339;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_WARPS_PER_SM_NV = 0x933A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SM_COUNT_NV = 0x933B;
#endif
    }
}
#endif