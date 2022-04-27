#if (GL_EXT_geometry_shader4 && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glProgramParameteriEXT(GLuint program, GLenum pname, GLint value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramParameterPName, GLint, void> glProgramParameteriEXT;
    }
}
#endif