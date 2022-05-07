#if (GL_EXT_shader_framebuffer_fetch && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_FRAGMENT_SHADER_DISCARDS_SAMPLES_EXT = 0x8A52;
    }
}
#endif