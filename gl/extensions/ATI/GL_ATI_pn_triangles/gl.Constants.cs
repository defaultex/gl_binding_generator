#if (GL_ATI_pn_triangles && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_PN_TRIANGLES_ATI = 0x87F0;
        public const GLenum GL_MAX_PN_TRIANGLES_TESSELATION_LEVEL_ATI = 0x87F1;
        public const GLenum GL_PN_TRIANGLES_POINT_MODE_ATI = 0x87F2;
        public const GLenum GL_PN_TRIANGLES_NORMAL_MODE_ATI = 0x87F3;
        public const GLenum GL_PN_TRIANGLES_TESSELATION_LEVEL_ATI = 0x87F4;
        public const GLenum GL_PN_TRIANGLES_POINT_MODE_LINEAR_ATI = 0x87F5;
        public const GLenum GL_PN_TRIANGLES_POINT_MODE_CUBIC_ATI = 0x87F6;
        public const GLenum GL_PN_TRIANGLES_NORMAL_MODE_LINEAR_ATI = 0x87F7;
        public const GLenum GL_PN_TRIANGLES_NORMAL_MODE_QUADRATIC_ATI = 0x87F8;
    }
}
#endif