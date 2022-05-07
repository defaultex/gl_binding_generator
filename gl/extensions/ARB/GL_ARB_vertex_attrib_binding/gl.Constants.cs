#if (GL_ARB_vertex_attrib_binding && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_VERTEX_ATTRIB_BINDING = 0x82D4;
        public const GLenum GL_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5;
        public const GLenum GL_VERTEX_BINDING_DIVISOR = 0x82D6;
        public const GLenum GL_VERTEX_BINDING_OFFSET = 0x82D7;
        public const GLenum GL_VERTEX_BINDING_STRIDE = 0x82D8;
        public const GLenum GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D9;
        public const GLenum GL_MAX_VERTEX_ATTRIB_BINDINGS = 0x82DA;
    }
}
#endif