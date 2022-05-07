#if (GL_SGIS_fog_function && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_FOG_FUNC_SGIS = 0x812A;
        public const GLenum GL_FOG_FUNC_POINTS_SGIS = 0x812B;
        public const GLenum GL_MAX_FOG_FUNC_POINTS_SGIS = 0x812C;
    }
}
#endif