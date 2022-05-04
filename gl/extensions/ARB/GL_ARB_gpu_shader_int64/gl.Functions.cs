#if (GL_ARB_gpu_shader_int64 && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetnUniformi64vARB(GLuint program, GLint location, GLsizei bufSize, GLint64* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLint64*, void> glGetnUniformi64vARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetnUniformui64vARB(GLuint program, GLint location, GLsizei bufSize, GLuint64* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLuint64*, void> glGetnUniformui64vARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetUniformi64vARB(GLuint program, GLint location, GLint64* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLint64*, void> glGetUniformi64vARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetUniformui64vARB(GLuint program, GLint location, GLuint64* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLuint64*, void> glGetUniformui64vARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform1i64ARB(GLuint program, GLint location, GLint64 x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLint64, void> glProgramUniform1i64ARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform1i64vARB(GLuint program, GLint location, GLsizei count, GLint64* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLint64*, void> glProgramUniform1i64vARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform1ui64ARB(GLuint program, GLint location, GLuint64 x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLuint64, void> glProgramUniform1ui64ARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform1ui64vARB(GLuint program, GLint location, GLsizei count, GLuint64* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLuint64*, void> glProgramUniform1ui64vARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform2i64ARB(GLuint program, GLint location, GLint64 x, GLint64 y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLint64, GLint64, void> glProgramUniform2i64ARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform2i64vARB(GLuint program, GLint location, GLsizei count, GLint64* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLint64*, void> glProgramUniform2i64vARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform2ui64ARB(GLuint program, GLint location, GLuint64 x, GLuint64 y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLuint64, GLuint64, void> glProgramUniform2ui64ARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform2ui64vARB(GLuint program, GLint location, GLsizei count, GLuint64* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLuint64*, void> glProgramUniform2ui64vARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform3i64ARB(GLuint program, GLint location, GLint64 x, GLint64 y, GLint64 z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLint64, GLint64, GLint64, void> glProgramUniform3i64ARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform3i64vARB(GLuint program, GLint location, GLsizei count, GLint64* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLint64*, void> glProgramUniform3i64vARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform3ui64ARB(GLuint program, GLint location, GLuint64 x, GLuint64 y, GLuint64 z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLuint64, GLuint64, GLuint64, void> glProgramUniform3ui64ARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform3ui64vARB(GLuint program, GLint location, GLsizei count, GLuint64* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLuint64*, void> glProgramUniform3ui64vARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform4i64ARB(GLuint program, GLint location, GLint64 x, GLint64 y, GLint64 z, GLint64 w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLint64, GLint64, GLint64, GLint64, void> glProgramUniform4i64ARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform4i64vARB(GLuint program, GLint location, GLsizei count, GLint64* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLint64*, void> glProgramUniform4i64vARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform4ui64ARB(GLuint program, GLint location, GLuint64 x, GLuint64 y, GLuint64 z, GLuint64 w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLuint64, GLuint64, GLuint64, GLuint64, void> glProgramUniform4ui64ARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform4ui64vARB(GLuint program, GLint location, GLsizei count, GLuint64* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLuint64*, void> glProgramUniform4ui64vARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform1i64ARB(GLint location, GLint64 x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint64, void> glUniform1i64ARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform1i64vARB(GLint location, GLsizei count, GLint64* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint64*, void> glUniform1i64vARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform1ui64ARB(GLint location, GLuint64 x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint64, void> glUniform1ui64ARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform1ui64vARB(GLint location, GLsizei count, GLuint64* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint64*, void> glUniform1ui64vARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform2i64ARB(GLint location, GLint64 x, GLint64 y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint64, GLint64, void> glUniform2i64ARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform2i64vARB(GLint location, GLsizei count, GLint64* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint64*, void> glUniform2i64vARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform2ui64ARB(GLint location, GLuint64 x, GLuint64 y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint64, GLuint64, void> glUniform2ui64ARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform2ui64vARB(GLint location, GLsizei count, GLuint64* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint64*, void> glUniform2ui64vARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform3i64ARB(GLint location, GLint64 x, GLint64 y, GLint64 z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint64, GLint64, GLint64, void> glUniform3i64ARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform3i64vARB(GLint location, GLsizei count, GLint64* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint64*, void> glUniform3i64vARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform3ui64ARB(GLint location, GLuint64 x, GLuint64 y, GLuint64 z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint64, GLuint64, GLuint64, void> glUniform3ui64ARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform3ui64vARB(GLint location, GLsizei count, GLuint64* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint64*, void> glUniform3ui64vARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform4i64ARB(GLint location, GLint64 x, GLint64 y, GLint64 z, GLint64 w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint64, GLint64, GLint64, GLint64, void> glUniform4i64ARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform4i64vARB(GLint location, GLsizei count, GLint64* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint64*, void> glUniform4i64vARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform4ui64ARB(GLint location, GLuint64 x, GLuint64 y, GLuint64 z, GLuint64 w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint64, GLuint64, GLuint64, GLuint64, void> glUniform4ui64ARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform4ui64vARB(GLint location, GLsizei count, GLuint64* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint64*, void> glUniform4ui64vARB;
#endif
    }
}
#endif