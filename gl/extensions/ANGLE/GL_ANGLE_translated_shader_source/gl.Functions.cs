#if (GL_ANGLE_translated_shader_source && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glGetTranslatedShaderSourceANGLE(GLuint shader, GLsizei bufSize, GLsizei* length, GLchar* source)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshader, GLsizei, GLsizei*, GLchar*, void> glGetTranslatedShaderSourceANGLE;
    }
}
#endif