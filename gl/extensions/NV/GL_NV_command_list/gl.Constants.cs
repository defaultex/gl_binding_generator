#if (GL_NV_command_list && (GL_API || GLCORE_API))
public partial class glext_nv { 
    public partial class Constants { 
        public const GLenum GL_TERMINATE_SEQUENCE_COMMAND_NV = 0x0000;
        public const GLenum GL_NOP_COMMAND_NV = 0x0001;
        public const GLenum GL_DRAW_ELEMENTS_COMMAND_NV = 0x0002;
        public const GLenum GL_DRAW_ARRAYS_COMMAND_NV = 0x0003;
        public const GLenum GL_DRAW_ELEMENTS_STRIP_COMMAND_NV = 0x0004;
        public const GLenum GL_DRAW_ARRAYS_STRIP_COMMAND_NV = 0x0005;
        public const GLenum GL_DRAW_ELEMENTS_INSTANCED_COMMAND_NV = 0x0006;
        public const GLenum GL_DRAW_ARRAYS_INSTANCED_COMMAND_NV = 0x0007;
        public const GLenum GL_ELEMENT_ADDRESS_COMMAND_NV = 0x0008;
        public const GLenum GL_ATTRIBUTE_ADDRESS_COMMAND_NV = 0x0009;
        public const GLenum GL_UNIFORM_ADDRESS_COMMAND_NV = 0x000A;
        public const GLenum GL_BLEND_COLOR_COMMAND_NV = 0x000B;
        public const GLenum GL_STENCIL_REF_COMMAND_NV = 0x000C;
        public const GLenum GL_LINE_WIDTH_COMMAND_NV = 0x000D;
        public const GLenum GL_POLYGON_OFFSET_COMMAND_NV = 0x000E;
        public const GLenum GL_ALPHA_REF_COMMAND_NV = 0x000F;
        public const GLenum GL_VIEWPORT_COMMAND_NV = 0x0010;
        public const GLenum GL_SCISSOR_COMMAND_NV = 0x0011;
        public const GLenum GL_FRONT_FACE_COMMAND_NV = 0x0012;
    }
}
#endif