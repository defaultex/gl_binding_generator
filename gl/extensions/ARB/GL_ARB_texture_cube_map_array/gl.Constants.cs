#if (GL_ARB_texture_cube_map_array && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_CUBE_MAP_ARRAY_ARB = 0x9009;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_BINDING_CUBE_MAP_ARRAY_ARB = 0x900A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PROXY_TEXTURE_CUBE_MAP_ARRAY_ARB = 0x900B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLER_CUBE_MAP_ARRAY_ARB = 0x900C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW_ARB = 0x900D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INT_SAMPLER_CUBE_MAP_ARRAY_ARB = 0x900E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_ARB = 0x900F;
#endif
    }
}
#endif