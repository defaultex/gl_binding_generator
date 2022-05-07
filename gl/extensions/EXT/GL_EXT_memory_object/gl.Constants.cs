#if (GL_EXT_memory_object && (!gl || !gles2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_UUID_SIZE_EXT = 16;
        public const GLenum GL_TEXTURE_TILING_EXT = 0x9580;
        public const GLenum GL_DEDICATED_MEMORY_OBJECT_EXT = 0x9581;
        public const GLenum GL_NUM_TILING_TYPES_EXT = 0x9582;
        public const GLenum GL_TILING_TYPES_EXT = 0x9583;
        public const GLenum GL_OPTIMAL_TILING_EXT = 0x9584;
        public const GLenum GL_LINEAR_TILING_EXT = 0x9585;
        public const GLenum GL_NUM_DEVICE_UUIDS_EXT = 0x9596;
        public const GLenum GL_DEVICE_UUID_EXT = 0x9597;
        public const GLenum GL_DRIVER_UUID_EXT = 0x9598;
        public const GLenum GL_PROTECTED_MEMORY_OBJECT_EXT = 0x959B;
    }
}
#endif