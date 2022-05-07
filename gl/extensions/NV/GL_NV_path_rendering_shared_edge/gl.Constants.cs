#if (GL_NV_path_rendering_shared_edge && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_SHARED_EDGE_NV = 0xC0;
    }
}
#endif