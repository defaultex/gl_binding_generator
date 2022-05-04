#if (GL_NV_vertex_attrib_integer_64bit && (GL_API || GLCORE_API))
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INT64_NV = 0x140E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT64_NV = 0x140F;
#endif
    }
}
#endif