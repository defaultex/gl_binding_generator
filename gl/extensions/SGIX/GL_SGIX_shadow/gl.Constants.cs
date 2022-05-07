#if (GL_SGIX_shadow && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_COMPARE_SGIX = 0x819A;
        public const GLenum GL_TEXTURE_COMPARE_OPERATOR_SGIX = 0x819B;
        public const GLenum GL_TEXTURE_LEQUAL_R_SGIX = 0x819C;
        public const GLenum GL_TEXTURE_GEQUAL_R_SGIX = 0x819D;
    }
}
#endif