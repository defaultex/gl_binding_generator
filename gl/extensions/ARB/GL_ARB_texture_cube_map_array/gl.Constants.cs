#if (GL_ARB_texture_cube_map_array && (GL_API || GLCORE_API))
public partial class glext_arb { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_CUBE_MAP_ARRAY_ARB = 0x9009;
        public const GLenum GL_TEXTURE_BINDING_CUBE_MAP_ARRAY_ARB = 0x900A;
        public const GLenum GL_PROXY_TEXTURE_CUBE_MAP_ARRAY_ARB = 0x900B;
        public const GLenum GL_SAMPLER_CUBE_MAP_ARRAY_ARB = 0x900C;
        public const GLenum GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW_ARB = 0x900D;
        public const GLenum GL_INT_SAMPLER_CUBE_MAP_ARRAY_ARB = 0x900E;
        public const GLenum GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_ARB = 0x900F;
    }
}
#endif