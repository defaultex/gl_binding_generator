#if (GL_SGIS_texture_edge_clamp && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_CLAMP_TO_EDGE_SGIS = 0x812F;
    }
}
#endif