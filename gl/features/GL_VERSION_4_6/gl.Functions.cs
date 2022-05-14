public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, void*, GLintptr, GLsizei, GLsizei, void> glMultiDrawArraysIndirectCount;
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, ElementType, void*, GLintptr, GLsizei, GLsizei, void> glMultiDrawElementsIndirectCount;
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, void> glPolygonOffsetClamp;
        public static unsafe delegate* unmanaged[Cdecl]<GLshader, GLchar*, GLuint, GLuint*, GLuint*, void> glSpecializeShader;
    }
}
