#if (GL_FJ_shader_binary_GCCSO && GLES2_API)
public partial class fj { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_GCCSO_SHADER_BINARY_FJ = 0x9260;
#endif
    }
}
#endif