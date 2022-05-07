#if (GL_EXT_semaphore && (!gl || !gles2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_UUID_SIZE_EXT = 16;
        public const GLenum GL_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_EXT = 0x9530;
        public const GLenum GL_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_EXT = 0x9531;
        public const GLenum GL_LAYOUT_GENERAL_EXT = 0x958D;
        public const GLenum GL_LAYOUT_COLOR_ATTACHMENT_EXT = 0x958E;
        public const GLenum GL_LAYOUT_DEPTH_STENCIL_ATTACHMENT_EXT = 0x958F;
        public const GLenum GL_LAYOUT_DEPTH_STENCIL_READ_ONLY_EXT = 0x9590;
        public const GLenum GL_LAYOUT_SHADER_READ_ONLY_EXT = 0x9591;
        public const GLenum GL_LAYOUT_TRANSFER_SRC_EXT = 0x9592;
        public const GLenum GL_LAYOUT_TRANSFER_DST_EXT = 0x9593;
        public const GLenum GL_NUM_DEVICE_UUIDS_EXT = 0x9596;
        public const GLenum GL_DEVICE_UUID_EXT = 0x9597;
        public const GLenum GL_DRIVER_UUID_EXT = 0x9598;
    }
}
#endif