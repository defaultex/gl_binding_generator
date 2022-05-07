#if (GL_SGIX_texture_add_env && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_ENV_BIAS_SGIX = 0x80BE;
    }
}
#endif