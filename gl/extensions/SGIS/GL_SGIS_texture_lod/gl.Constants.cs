#if (GL_SGIS_texture_lod && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_MIN_LOD_SGIS = 0x813A;
        public const GLenum GL_TEXTURE_MAX_LOD_SGIS = 0x813B;
        public const GLenum GL_TEXTURE_BASE_LEVEL_SGIS = 0x813C;
        public const GLenum GL_TEXTURE_MAX_LEVEL_SGIS = 0x813D;
    }
}
#endif