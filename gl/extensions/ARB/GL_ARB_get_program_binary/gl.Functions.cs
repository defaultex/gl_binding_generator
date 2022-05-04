#if (GL_ARB_get_program_binary && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetProgramBinary(GLuint program, GLsizei bufSize, GLsizei* length, GLenum* binaryFormat, void* binary);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLsizei, GLsizei*, GLenum*, void*, void> glGetProgramBinary;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glProgramBinary(GLuint program, GLenum binaryFormat, void* binary, GLsizei length);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLenum, void*, GLsizei, void> glProgramBinary;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glProgramParameteri(GLuint program, GLenum pname, GLint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramParameterPName, GLint, void> glProgramParameteri;
#endif
    }
}
#endif