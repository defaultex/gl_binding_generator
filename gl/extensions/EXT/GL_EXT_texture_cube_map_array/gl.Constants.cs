#if (GL_EXT_texture_cube_map_array && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_CUBE_MAP_ARRAY_EXT = 0x9009;
        public const GLenum GL_TEXTURE_BINDING_CUBE_MAP_ARRAY_EXT = 0x900A;
        public const GLenum GL_SAMPLER_CUBE_MAP_ARRAY_EXT = 0x900C;
        public const GLenum GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW_EXT = 0x900D;
        public const GLenum GL_INT_SAMPLER_CUBE_MAP_ARRAY_EXT = 0x900E;
        public const GLenum GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_EXT = 0x900F;
        public const GLenum GL_IMAGE_CUBE_MAP_ARRAY_EXT = 0x9054;
        public const GLenum GL_INT_IMAGE_CUBE_MAP_ARRAY_EXT = 0x905F;
        public const GLenum GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY_EXT = 0x906A;
    }
}
#endif