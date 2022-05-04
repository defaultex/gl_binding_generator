#if (GL_DMP_shader_binary && GLES2_API)
public partial class dmp { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADER_BINARY_DMP = 0x9250;
#endif
    }
}
#endif