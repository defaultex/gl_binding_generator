#if (GL_WIN_specular_fog && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_FOG_SPECULAR_TEXTURE_WIN = 0x80EC;
    }
}
#endif