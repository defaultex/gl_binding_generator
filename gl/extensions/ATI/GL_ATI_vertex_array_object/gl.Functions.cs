#if (GL_ATI_vertex_array_object && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glArrayObjectATI(GLenum array, GLint size, GLenum type, GLsizei stride, GLuint buffer, GLuint offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLint, ScalarType, GLsizei, buffer, GLuint, void> glArrayObjectATI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFreeObjectBufferATI(GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, void> glFreeObjectBufferATI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetArrayObjectfvATI(GLenum array, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, ArrayObjectPNameATI, GLfloat*, void> glGetArrayObjectfvATI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetArrayObjectivATI(GLenum array, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, ArrayObjectPNameATI, GLint*, void> glGetArrayObjectivATI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetObjectBufferfvATI(GLuint buffer, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, ArrayObjectPNameATI, GLfloat*, void> glGetObjectBufferfvATI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetObjectBufferivATI(GLuint buffer, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, ArrayObjectPNameATI, GLint*, void> glGetObjectBufferivATI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetVariantArrayObjectfvATI(GLuint id, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ArrayObjectPNameATI, GLfloat*, void> glGetVariantArrayObjectfvATI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetVariantArrayObjectivATI(GLuint id, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ArrayObjectPNameATI, GLint*, void> glGetVariantArrayObjectivATI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsObjectBufferATI(GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, GLboolean> glIsObjectBufferATI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLuint glNewObjectBufferATI(GLsizei size, void* pointer, GLenum usage);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, void*, ArrayObjectUsageATI, GLuint> glNewObjectBufferATI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUpdateObjectBufferATI(GLuint buffer, GLuint offset, GLsizei size, void* pointer, GLenum preserve);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, GLuint, GLsizei, void*, PreserveModeATI, void> glUpdateObjectBufferATI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVariantArrayObjectATI(GLuint id, GLenum type, GLsizei stride, GLuint buffer, GLuint offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ScalarType, GLsizei, buffer, GLuint, void> glVariantArrayObjectATI;
#endif
    }
}
#endif