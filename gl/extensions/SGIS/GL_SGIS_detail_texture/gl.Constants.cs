#if (GL_SGIS_detail_texture && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_DETAIL_TEXTURE_2D_SGIS = 0x8095;
        public const GLenum GL_DETAIL_TEXTURE_2D_BINDING_SGIS = 0x8096;
        public const GLenum GL_LINEAR_DETAIL_SGIS = 0x8097;
        public const GLenum GL_LINEAR_DETAIL_ALPHA_SGIS = 0x8098;
        public const GLenum GL_LINEAR_DETAIL_COLOR_SGIS = 0x8099;
        public const GLenum GL_DETAIL_TEXTURE_LEVEL_SGIS = 0x809A;
        public const GLenum GL_DETAIL_TEXTURE_MODE_SGIS = 0x809B;
        public const GLenum GL_DETAIL_TEXTURE_FUNC_POINTS_SGIS = 0x809C;
    }
}
#endif