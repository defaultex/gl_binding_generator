#if (GL_ARM_shader_framebuffer_fetch && GLES2_API)
public partial class glext_arm { 
    public partial class Constants { 
        public const GLenum GL_FETCH_PER_SAMPLE_ARM = 0x8F65;
        public const GLenum GL_FRAGMENT_SHADER_FRAMEBUFFER_FETCH_MRT_ARM = 0x8F66;
    }
}
#endif