#if (GL_ATI_element_array && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glDrawElementArrayATI(GLenum mode, GLsizei count)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, void> glDrawElementArrayATI;

        /// <summary>void glDrawRangeElementArrayATI(GLenum mode, GLuint start, GLuint end, GLsizei count)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLuint, GLuint, GLsizei, void> glDrawRangeElementArrayATI;

        /// <summary>void glElementPointerATI(GLenum type, const void* pointer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ElementPointerTypeATI, void*, void> glElementPointerATI;
    }
}
#endif