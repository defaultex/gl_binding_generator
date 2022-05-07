#if (GL_EXT_shadow_samplers && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_COMPARE_MODE_EXT = 0x884C;
        public const GLenum GL_TEXTURE_COMPARE_FUNC_EXT = 0x884D;
        public const GLenum GL_COMPARE_REF_TO_TEXTURE_EXT = 0x884E;
        public const GLenum GL_SAMPLER_2D_SHADOW_EXT = 0x8B62;
    }
}
#endif