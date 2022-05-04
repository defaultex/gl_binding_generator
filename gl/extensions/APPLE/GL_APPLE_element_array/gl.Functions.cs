#if (GL_APPLE_element_array && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDrawElementArrayAPPLE(GLenum mode, GLint first, GLsizei count);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint, GLsizei, void> glDrawElementArrayAPPLE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDrawRangeElementArrayAPPLE(GLenum mode, GLuint start, GLuint end, GLint first, GLsizei count);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLuint, GLuint, GLint, GLsizei, void> glDrawRangeElementArrayAPPLE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glElementPointerAPPLE(GLenum type, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ElementPointerTypeATI, void*, void> glElementPointerAPPLE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiDrawElementArrayAPPLE(GLenum mode, GLint* first, GLsizei* count, GLsizei primcount);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint*, GLsizei*, GLsizei, void> glMultiDrawElementArrayAPPLE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiDrawRangeElementArrayAPPLE(GLenum mode, GLuint start, GLuint end, GLint* first, GLsizei* count, GLsizei primcount);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLuint, GLuint, GLint*, GLsizei*, GLsizei, void> glMultiDrawRangeElementArrayAPPLE;
#endif
    }
}
#endif