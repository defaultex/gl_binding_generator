#if (GL_NV_parameter_buffer_object && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glProgramBufferParametersfvNV(GLenum target, GLuint bindingIndex, GLuint wordIndex, GLsizei count, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLuint, GLsizei, GLfloat*, void> glProgramBufferParametersfvNV;

        /// <summary>void glProgramBufferParametersIivNV(GLenum target, GLuint bindingIndex, GLuint wordIndex, GLsizei count, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLuint, GLsizei, GLint*, void> glProgramBufferParametersIivNV;

        /// <summary>void glProgramBufferParametersIuivNV(GLenum target, GLuint bindingIndex, GLuint wordIndex, GLsizei count, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLuint, GLsizei, GLuint*, void> glProgramBufferParametersIuivNV;
    }
}
#endif