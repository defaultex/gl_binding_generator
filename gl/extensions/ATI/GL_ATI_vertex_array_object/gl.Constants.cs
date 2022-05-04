#if (GL_ATI_vertex_array_object && GL_API)
public partial class ati { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_STATIC_ATI = 0x8760;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DYNAMIC_ATI = 0x8761;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PRESERVE_ATI = 0x8762;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DISCARD_ATI = 0x8763;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_OBJECT_BUFFER_SIZE_ATI = 0x8764;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_OBJECT_BUFFER_USAGE_ATI = 0x8765;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ARRAY_OBJECT_BUFFER_ATI = 0x8766;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ARRAY_OBJECT_OFFSET_ATI = 0x8767;
#endif
    }
}
#endif