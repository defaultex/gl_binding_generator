#if (GL_SGIX_texture_coordinate_clamp && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_MAX_CLAMP_S_SGIX = 0x8369;
        public const GLenum GL_TEXTURE_MAX_CLAMP_T_SGIX = 0x836A;
        public const GLenum GL_TEXTURE_MAX_CLAMP_R_SGIX = 0x836B;
    }
}
#endif