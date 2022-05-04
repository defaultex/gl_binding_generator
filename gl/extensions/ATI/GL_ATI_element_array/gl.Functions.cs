#if (GL_ATI_element_array && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDrawElementArrayATI(GLenum mode, GLsizei count);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, void> glDrawElementArrayATI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDrawRangeElementArrayATI(GLenum mode, GLuint start, GLuint end, GLsizei count);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLuint, GLuint, GLsizei, void> glDrawRangeElementArrayATI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glElementPointerATI(GLenum type, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ElementPointerTypeATI, void*, void> glElementPointerATI;
#endif
    }
}
#endif