#if (GL_APPLE_element_array && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glDrawElementArrayAPPLE(GLenum mode, GLint first, GLsizei count);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint, GLsizei, void> glDrawElementArrayAPPLE;

        /// <summary>void glDrawRangeElementArrayAPPLE(GLenum mode, GLuint start, GLuint end, GLint first, GLsizei count);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLuint, GLuint, GLint, GLsizei, void> glDrawRangeElementArrayAPPLE;

        /// <summary>void glElementPointerAPPLE(GLenum type, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ElementPointerTypeATI, void*, void> glElementPointerAPPLE;

        /// <summary>void glMultiDrawElementArrayAPPLE(GLenum mode, GLint* first, GLsizei* count, GLsizei primcount);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint*, GLsizei*, GLsizei, void> glMultiDrawElementArrayAPPLE;

        /// <summary>void glMultiDrawRangeElementArrayAPPLE(GLenum mode, GLuint start, GLuint end, GLint* first, GLsizei* count, GLsizei primcount);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLuint, GLuint, GLint*, GLsizei*, GLsizei, void> glMultiDrawRangeElementArrayAPPLE;
    }
}
#endif