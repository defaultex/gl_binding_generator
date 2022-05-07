#if (GL_NV_query_resource && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>GLint glQueryResourceNV(GLenum queryType, GLint tagId, GLuint count, GLint* buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLint, GLuint, GLint*, GLint> glQueryResourceNV;
    }
}
#endif