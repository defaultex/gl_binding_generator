#if (GL_SGIS_texture_border_clamp && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_CLAMP_TO_BORDER_SGIS = 0x812D;
    }
}
#endif