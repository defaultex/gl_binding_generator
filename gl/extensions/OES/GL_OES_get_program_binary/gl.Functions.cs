#if (GL_OES_get_program_binary && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetProgramBinaryOES(GLuint program, GLsizei bufSize, GLsizei* length, GLenum* binaryFormat, void* binary);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLsizei, GLsizei*, GLenum*, void*, void> glGetProgramBinaryOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramBinaryOES(GLuint program, GLenum binaryFormat, void* binary, GLint length);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLenum, void*, GLint, void> glProgramBinaryOES;
#endif
    }
}
#endif