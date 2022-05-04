#if (GL_IMG_shader_binary && GLES2_API)
public partial class img { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SGX_BINARY_IMG = 0x8C0A;
#endif
    }
}
#endif