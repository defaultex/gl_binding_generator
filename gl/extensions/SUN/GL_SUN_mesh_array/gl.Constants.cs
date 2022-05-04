#if (GL_SUN_mesh_array && GL_API)
public partial class sun { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_QUAD_MESH_SUN = 0x8614;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TRIANGLE_MESH_SUN = 0x8615;
#endif
    }
}
#endif