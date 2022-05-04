#if (GL_NV_conditional_render && (GL_API || GLCORE_API || GLES2_API))
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_QUERY_WAIT_NV = 0x8E13;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_QUERY_NO_WAIT_NV = 0x8E14;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_QUERY_BY_REGION_WAIT_NV = 0x8E15;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_QUERY_BY_REGION_NO_WAIT_NV = 0x8E16;
#endif
    }
}
#endif