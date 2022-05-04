#if (GL_NV_memory_attachment && (GL_API || GLCORE_API || GLES2_API))
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ATTACHED_MEMORY_OBJECT_NV = 0x95A4;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ATTACHED_MEMORY_OFFSET_NV = 0x95A5;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MEMORY_ATTACHABLE_ALIGNMENT_NV = 0x95A6;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MEMORY_ATTACHABLE_SIZE_NV = 0x95A7;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MEMORY_ATTACHABLE_NV = 0x95A8;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DETACHED_MEMORY_INCARNATION_NV = 0x95A9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DETACHED_TEXTURES_NV = 0x95AA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DETACHED_BUFFERS_NV = 0x95AB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_DETACHED_TEXTURES_NV = 0x95AC;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_DETACHED_BUFFERS_NV = 0x95AD;
#endif
    }
}
#endif