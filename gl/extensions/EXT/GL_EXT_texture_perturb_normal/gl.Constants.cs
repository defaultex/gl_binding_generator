#if (GL_EXT_texture_perturb_normal && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_PERTURB_EXT = 0x85AE;
        public const GLenum GL_TEXTURE_NORMAL_EXT = 0x85AF;
    }
}
#endif