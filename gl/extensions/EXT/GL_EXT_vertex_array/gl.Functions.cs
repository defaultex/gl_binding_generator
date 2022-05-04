#if (GL_EXT_vertex_array && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glArrayElementEXT(GLint i);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, void> glArrayElementEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glColorPointerEXT(GLint size, GLenum type, GLsizei stride, GLsizei count, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, ColorPointerType, GLsizei, GLsizei, void*, void> glColorPointerEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDrawArraysEXT(GLenum mode, GLint first, GLsizei count);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint, GLsizei, void> glDrawArraysEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEdgeFlagPointerEXT(GLsizei stride, GLsizei count, GLboolean* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLsizei, GLboolean*, void> glEdgeFlagPointerEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetPointervEXT(GLenum pname, void** params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPointervPName, void**, void> glGetPointervEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glIndexPointerEXT(GLenum type, GLsizei stride, GLsizei count, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<IndexPointerType, GLsizei, GLsizei, void*, void> glIndexPointerEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNormalPointerEXT(GLenum type, GLsizei stride, GLsizei count, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<NormalPointerType, GLsizei, GLsizei, void*, void> glNormalPointerEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoordPointerEXT(GLint size, GLenum type, GLsizei stride, GLsizei count, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, TexCoordPointerType, GLsizei, GLsizei, void*, void> glTexCoordPointerEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexPointerEXT(GLint size, GLenum type, GLsizei stride, GLsizei count, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, VertexPointerType, GLsizei, GLsizei, void*, void> glVertexPointerEXT;
#endif
    }
}
#endif