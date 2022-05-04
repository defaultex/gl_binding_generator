#if (GL_NV_path_rendering_shared_edge && (GL_API || GLCORE_API || GLES2_API))
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHARED_EDGE_NV = 0xC0;
#endif
    }
}
#endif