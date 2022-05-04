#if (GL_EXT_vertex_array_bgra && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_BGRA = 0x80E1;
#endif
    }
}
#endif