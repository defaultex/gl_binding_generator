#if (GL_EXT_cull_vertex && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_CULL_VERTEX_EXT = 0x81AA;
        public const GLenum GL_CULL_VERTEX_EYE_POSITION_EXT = 0x81AB;
        public const GLenum GL_CULL_VERTEX_OBJECT_POSITION_EXT = 0x81AC;
    }
}
#endif