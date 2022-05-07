#if (GL_EXT_color_buffer_half_float && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE_EXT = 0x8211;
        public const GLenum GL_R16F_EXT = 0x822D;
        public const GLenum GL_RG16F_EXT = 0x822F;
        public const GLenum GL_RGBA16F_EXT = 0x881A;
        public const GLenum GL_RGB16F_EXT = 0x881B;
        public const GLenum GL_UNSIGNED_NORMALIZED_EXT = 0x8C17;
    }
}
#endif