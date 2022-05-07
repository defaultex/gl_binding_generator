#if (GL_EXT_vertex_array && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glArrayElementEXT(GLint i);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, void> glArrayElementEXT;

        /// <summary>void glColorPointerEXT(GLint size, GLenum type, GLsizei stride, GLsizei count, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, ColorPointerType, GLsizei, GLsizei, void*, void> glColorPointerEXT;

        /// <summary>void glDrawArraysEXT(GLenum mode, GLint first, GLsizei count);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint, GLsizei, void> glDrawArraysEXT;

        /// <summary>void glEdgeFlagPointerEXT(GLsizei stride, GLsizei count, GLboolean* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLsizei, GLboolean*, void> glEdgeFlagPointerEXT;

        /// <summary>void glGetPointervEXT(GLenum pname, void** params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPointervPName, void**, void> glGetPointervEXT;

        /// <summary>void glIndexPointerEXT(GLenum type, GLsizei stride, GLsizei count, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<IndexPointerType, GLsizei, GLsizei, void*, void> glIndexPointerEXT;

        /// <summary>void glNormalPointerEXT(GLenum type, GLsizei stride, GLsizei count, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<NormalPointerType, GLsizei, GLsizei, void*, void> glNormalPointerEXT;

        /// <summary>void glTexCoordPointerEXT(GLint size, GLenum type, GLsizei stride, GLsizei count, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, TexCoordPointerType, GLsizei, GLsizei, void*, void> glTexCoordPointerEXT;

        /// <summary>void glVertexPointerEXT(GLint size, GLenum type, GLsizei stride, GLsizei count, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, VertexPointerType, GLsizei, GLsizei, void*, void> glVertexPointerEXT;
    }
}
#endif