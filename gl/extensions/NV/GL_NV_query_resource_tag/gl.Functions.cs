#if (GL_NV_query_resource_tag && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glDeleteQueryResourceTagNV(GLsizei n, const GLint* tagIds)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLint*, void> glDeleteQueryResourceTagNV;

        /// <summary>void glGenQueryResourceTagNV(GLsizei n, GLint* tagIds)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLint*, void> glGenQueryResourceTagNV;

        /// <summary>void glQueryResourceTagNV(GLint tagId, const GLchar* tagString)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLchar*, void> glQueryResourceTagNV;
    }
}
#endif