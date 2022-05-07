#if (GL_SGIX_vertex_preclip && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_VERTEX_PRECLIP_SGIX = 0x83EE;
        public const GLenum GL_VERTEX_PRECLIP_HINT_SGIX = 0x83EF;
    }
}
#endif