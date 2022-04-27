#if (GL_NV_parameter_buffer_object && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glProgramBufferParametersIivNV(GLenum target, GLuint bindingIndex, GLuint wordIndex, GLsizei count, const GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLuint, GLsizei, GLint*, void> glProgramBufferParametersIivNV;

        /// <summary>void glProgramBufferParametersIuivNV(GLenum target, GLuint bindingIndex, GLuint wordIndex, GLsizei count, const GLuint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLuint, GLsizei, GLuint*, void> glProgramBufferParametersIuivNV;

        /// <summary>void glProgramBufferParametersfvNV(GLenum target, GLuint bindingIndex, GLuint wordIndex, GLsizei count, const GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLuint, GLsizei, GLfloat*, void> glProgramBufferParametersfvNV;
    }
}
#endif