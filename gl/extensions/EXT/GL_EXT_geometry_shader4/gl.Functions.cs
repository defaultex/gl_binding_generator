#if (GL_EXT_geometry_shader4 && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramParameteriEXT(GLuint program, GLenum pname, GLint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramParameterPName, GLint, void> glProgramParameteriEXT;
#endif
    }
}
#endif