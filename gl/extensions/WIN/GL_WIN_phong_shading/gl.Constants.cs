#if (GL_WIN_phong_shading && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_PHONG_WIN = 0x80EA;
        public const GLenum GL_PHONG_HINT_WIN = 0x80EB;
    }
}
#endif