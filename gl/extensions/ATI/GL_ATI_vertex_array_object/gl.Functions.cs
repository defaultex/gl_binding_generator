#if (GL_ATI_vertex_array_object && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glArrayObjectATI(GLenum array, GLint size, GLenum type, GLsizei stride, GLuint buffer, GLuint offset)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLint, ScalarType, GLsizei, GLbuffer, GLuint, void> glArrayObjectATI;

        /// <summary>void glFreeObjectBufferATI(GLuint buffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, void> glFreeObjectBufferATI;

        /// <summary>void glGetArrayObjectfvATI(GLenum array, GLenum pname, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, ArrayObjectPNameATI, GLfloat*, void> glGetArrayObjectfvATI;

        /// <summary>void glGetArrayObjectivATI(GLenum array, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, ArrayObjectPNameATI, GLint*, void> glGetArrayObjectivATI;

        /// <summary>void glGetObjectBufferfvATI(GLuint buffer, GLenum pname, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, ArrayObjectPNameATI, GLfloat*, void> glGetObjectBufferfvATI;

        /// <summary>void glGetObjectBufferivATI(GLuint buffer, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, ArrayObjectPNameATI, GLint*, void> glGetObjectBufferivATI;

        /// <summary>void glGetVariantArrayObjectfvATI(GLuint id, GLenum pname, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ArrayObjectPNameATI, GLfloat*, void> glGetVariantArrayObjectfvATI;

        /// <summary>void glGetVariantArrayObjectivATI(GLuint id, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ArrayObjectPNameATI, GLint*, void> glGetVariantArrayObjectivATI;

        /// <summary>GLboolean glIsObjectBufferATI(GLuint buffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLboolean> glIsObjectBufferATI;

        /// <summary>GLuint glNewObjectBufferATI(GLsizei size, const void* pointer, GLenum usage)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, void*, ArrayObjectUsageATI, GLuint> glNewObjectBufferATI;

        /// <summary>void glUpdateObjectBufferATI(GLuint buffer, GLuint offset, GLsizei size, const void* pointer, GLenum preserve)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLuint, GLsizei, void*, PreserveModeATI, void> glUpdateObjectBufferATI;

        /// <summary>void glVariantArrayObjectATI(GLuint id, GLenum type, GLsizei stride, GLuint buffer, GLuint offset)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ScalarType, GLsizei, GLbuffer, GLuint, void> glVariantArrayObjectATI;
    }
}
#endif