#if (GL_EXT_texture_cube_map && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_NORMAL_MAP_EXT = 0x8511;
        public const GLenum GL_REFLECTION_MAP_EXT = 0x8512;
        public const GLenum GL_TEXTURE_CUBE_MAP_EXT = 0x8513;
        public const GLenum GL_TEXTURE_BINDING_CUBE_MAP_EXT = 0x8514;
        public const GLenum GL_TEXTURE_CUBE_MAP_POSITIVE_X_EXT = 0x8515;
        public const GLenum GL_TEXTURE_CUBE_MAP_NEGATIVE_X_EXT = 0x8516;
        public const GLenum GL_TEXTURE_CUBE_MAP_POSITIVE_Y_EXT = 0x8517;
        public const GLenum GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_EXT = 0x8518;
        public const GLenum GL_TEXTURE_CUBE_MAP_POSITIVE_Z_EXT = 0x8519;
        public const GLenum GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_EXT = 0x851A;
        public const GLenum GL_PROXY_TEXTURE_CUBE_MAP_EXT = 0x851B;
        public const GLenum GL_MAX_CUBE_MAP_TEXTURE_SIZE_EXT = 0x851C;
    }
}
#endif