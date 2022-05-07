#if (GL_SGIS_generate_mipmap && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_GENERATE_MIPMAP_SGIS = 0x8191;
        public const GLenum GL_GENERATE_MIPMAP_HINT_SGIS = 0x8192;
    }
}
#endif