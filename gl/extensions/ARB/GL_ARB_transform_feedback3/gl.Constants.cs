#if (GL_ARB_transform_feedback3 && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_MAX_TRANSFORM_FEEDBACK_BUFFERS = 0x8E70;
        public const GLenum GL_MAX_VERTEX_STREAMS = 0x8E71;
    }
}
#endif