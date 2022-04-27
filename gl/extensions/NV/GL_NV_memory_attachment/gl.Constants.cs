#if (GL_NV_memory_attachment && (GL_API || GLCORE_API || GLES2_API))
public partial class glext_nv { 
    public partial class Constants { 
        public const GLenum GL_ATTACHED_MEMORY_OBJECT_NV = 0x95A4;
        public const GLenum GL_ATTACHED_MEMORY_OFFSET_NV = 0x95A5;
        public const GLenum GL_MEMORY_ATTACHABLE_ALIGNMENT_NV = 0x95A6;
        public const GLenum GL_MEMORY_ATTACHABLE_SIZE_NV = 0x95A7;
        public const GLenum GL_MEMORY_ATTACHABLE_NV = 0x95A8;
        public const GLenum GL_DETACHED_MEMORY_INCARNATION_NV = 0x95A9;
        public const GLenum GL_DETACHED_TEXTURES_NV = 0x95AA;
        public const GLenum GL_DETACHED_BUFFERS_NV = 0x95AB;
        public const GLenum GL_MAX_DETACHED_TEXTURES_NV = 0x95AC;
        public const GLenum GL_MAX_DETACHED_BUFFERS_NV = 0x95AD;
    }
}
#endif