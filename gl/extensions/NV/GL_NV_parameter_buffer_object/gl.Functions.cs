#if (GL_NV_parameter_buffer_object && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramBufferParametersfvNV(GLenum target, GLuint bindingIndex, GLuint wordIndex, GLsizei count, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLuint, GLsizei, GLfloat*, void> glProgramBufferParametersfvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramBufferParametersIivNV(GLenum target, GLuint bindingIndex, GLuint wordIndex, GLsizei count, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLuint, GLsizei, GLint*, void> glProgramBufferParametersIivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramBufferParametersIuivNV(GLenum target, GLuint bindingIndex, GLuint wordIndex, GLsizei count, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLuint, GLsizei, GLuint*, void> glProgramBufferParametersIuivNV;
#endif
    }
}
#endif