#if (GL_APPLE_element_array && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_ELEMENT_ARRAY_APPLE = 0x8A0C;
        public const GLenum GL_ELEMENT_ARRAY_TYPE_APPLE = 0x8A0D;
        public const GLenum GL_ELEMENT_ARRAY_POINTER_APPLE = 0x8A0E;
    }
}
#endif