#if (GL_VIV_shader_binary && GLES2_API)
public partial class viv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADER_BINARY_VIV = 0x8FC4;
#endif
    }
}
#endif