#if (GL_AMD_sample_positions && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glSetMultisamplefvAMD(GLenum pname, GLuint index, GLfloat* val);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLfloat*, void> glSetMultisamplefvAMD;
    }
}
#endif