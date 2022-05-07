#if (GL_ARB_enhanced_layouts && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E;
        public const GLenum GL_LOCATION_COMPONENT = 0x934A;
        public const GLenum GL_TRANSFORM_FEEDBACK_BUFFER_INDEX = 0x934B;
        public const GLenum GL_TRANSFORM_FEEDBACK_BUFFER_STRIDE = 0x934C;
    }
}
#endif