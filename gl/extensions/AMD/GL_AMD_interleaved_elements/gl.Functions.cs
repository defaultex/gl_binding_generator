#if (GL_AMD_interleaved_elements && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glVertexAttribParameteriAMD(GLuint index, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLenum, GLint, void> glVertexAttribParameteriAMD;
    }
}
#endif