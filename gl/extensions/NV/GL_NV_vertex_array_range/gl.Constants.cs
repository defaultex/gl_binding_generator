#if (GL_NV_vertex_array_range && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VERTEX_ARRAY_RANGE_NV = 0x851D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VERTEX_ARRAY_RANGE_LENGTH_NV = 0x851E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VERTEX_ARRAY_RANGE_VALID_NV = 0x851F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_VERTEX_ARRAY_RANGE_ELEMENT_NV = 0x8520;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VERTEX_ARRAY_RANGE_POINTER_NV = 0x8521;
#endif
    }
}
#endif