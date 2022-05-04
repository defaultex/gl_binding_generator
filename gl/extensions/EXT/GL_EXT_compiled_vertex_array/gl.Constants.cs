#if (GL_EXT_compiled_vertex_array && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ARRAY_ELEMENT_LOCK_FIRST_EXT = 0x81A8;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ARRAY_ELEMENT_LOCK_COUNT_EXT = 0x81A9;
#endif
    }
}
#endif