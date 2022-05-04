#if (GL_NV_blend_minmax_factor && (GL_API || GLCORE_API || GLES2_API))
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FACTOR_MIN_AMD = 0x901C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FACTOR_MAX_AMD = 0x901D;
#endif
    }
}
#endif