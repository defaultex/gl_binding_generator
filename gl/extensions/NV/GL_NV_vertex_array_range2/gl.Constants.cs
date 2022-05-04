#if (GL_NV_vertex_array_range2 && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VERTEX_ARRAY_RANGE_WITHOUT_FLUSH_NV = 0x8533;
#endif
    }
}
#endif