#if (GL_ATI_element_array && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_ELEMENT_ARRAY_ATI = 0x8768;
        public const GLenum GL_ELEMENT_ARRAY_TYPE_ATI = 0x8769;
        public const GLenum GL_ELEMENT_ARRAY_POINTER_ATI = 0x876A;
    }
}
#endif