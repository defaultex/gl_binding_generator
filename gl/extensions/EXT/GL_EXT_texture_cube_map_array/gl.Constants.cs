#if (GL_EXT_texture_cube_map_array && GLES2_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_CUBE_MAP_ARRAY_EXT = 0x9009;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_BINDING_CUBE_MAP_ARRAY_EXT = 0x900A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLER_CUBE_MAP_ARRAY_EXT = 0x900C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW_EXT = 0x900D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INT_SAMPLER_CUBE_MAP_ARRAY_EXT = 0x900E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_EXT = 0x900F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_IMAGE_CUBE_MAP_ARRAY_EXT = 0x9054;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INT_IMAGE_CUBE_MAP_ARRAY_EXT = 0x905F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY_EXT = 0x906A;
#endif
    }
}
#endif