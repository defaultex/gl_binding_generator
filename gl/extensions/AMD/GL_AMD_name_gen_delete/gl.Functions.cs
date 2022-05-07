#if (GL_AMD_name_gen_delete && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glDeleteNamesAMD(GLenum identifier, GLuint num, GLuint* names);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLuint*, void> glDeleteNamesAMD;

        /// <summary>void glGenNamesAMD(GLenum identifier, GLuint num, GLuint* names);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLuint*, void> glGenNamesAMD;

        /// <summary>GLboolean glIsNameAMD(GLenum identifier, GLuint name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLboolean> glIsNameAMD;
    }
}
#endif