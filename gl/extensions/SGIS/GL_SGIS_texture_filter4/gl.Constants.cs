#if (GL_SGIS_texture_filter4 && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_FILTER4_SGIS = 0x8146;
        public const GLenum GL_TEXTURE_FILTER4_SIZE_SGIS = 0x8147;
    }
}
#endif