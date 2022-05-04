#if (GL_VERSION_4_6 && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiDrawArraysIndirectCount(GLenum mode, void* indirect, GLintptr drawcount, GLsizei maxdrawcount, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, void*, GLintptr, GLsizei, GLsizei, void> glMultiDrawArraysIndirectCount;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiDrawElementsIndirectCount(GLenum mode, GLenum type, void* indirect, GLintptr drawcount, GLsizei maxdrawcount, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, DrawElementsType, void*, GLintptr, GLsizei, GLsizei, void> glMultiDrawElementsIndirectCount;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glPolygonOffsetClamp(GLfloat factor, GLfloat units, GLfloat clamp);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, void> glPolygonOffsetClamp;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glSpecializeShader(GLuint shader, GLchar* pEntryPoint, GLuint numSpecializationConstants, GLuint* pConstantIndex, GLuint* pConstantValue);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<shader, GLchar*, GLuint, GLuint*, GLuint*, void> glSpecializeShader;
#endif
    }
}
#endif