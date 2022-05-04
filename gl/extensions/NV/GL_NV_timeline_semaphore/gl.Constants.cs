#if (GL_NV_timeline_semaphore && (GL_API || GLES2_API))
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TIMELINE_SEMAPHORE_VALUE_NV = 0x9595;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SEMAPHORE_TYPE_NV = 0x95B3;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SEMAPHORE_TYPE_BINARY_NV = 0x95B4;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SEMAPHORE_TYPE_TIMELINE_NV = 0x95B5;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TIMELINE_SEMAPHORE_VALUE_DIFFERENCE_NV = 0x95B6;
#endif
    }
}
#endif