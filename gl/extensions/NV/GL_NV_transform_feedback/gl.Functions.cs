#if (GL_NV_transform_feedback && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glActiveVaryingNV(GLuint program, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLchar*, void> glActiveVaryingNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBeginTransformFeedbackNV(GLenum primitiveMode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, void> glBeginTransformFeedbackNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBindBufferBaseNV(GLenum target, GLuint index, GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, buffer, void> glBindBufferBaseNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBindBufferOffsetNV(GLenum target, GLuint index, GLuint buffer, GLintptr offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, buffer, GLintptr, void> glBindBufferOffsetNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBindBufferRangeNV(GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, buffer, GLintptr, GLsizeiptr, void> glBindBufferRangeNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEndTransformFeedbackNV();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glEndTransformFeedbackNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetActiveVaryingNV(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLsizei* size, GLenum* type, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLuint, GLsizei, GLsizei*, GLsizei*, GLenum*, GLchar*, void> glGetActiveVaryingNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetTransformFeedbackVaryingNV(GLuint program, GLuint index, GLint* location);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLuint, GLint*, void> glGetTransformFeedbackVaryingNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLint glGetVaryingLocationNV(GLuint program, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLchar*, GLint> glGetVaryingLocationNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTransformFeedbackAttribsNV(GLsizei count, GLint* attribs, GLenum bufferMode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLint*, GLenum, void> glTransformFeedbackAttribsNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTransformFeedbackStreamAttribsNV(GLsizei count, GLint* attribs, GLsizei nbuffers, GLint* bufstreams, GLenum bufferMode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLint*, GLsizei, GLint*, GLenum, void> glTransformFeedbackStreamAttribsNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTransformFeedbackVaryingsNV(GLuint program, GLsizei count, GLint* locations, GLenum bufferMode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLsizei, GLint*, GLenum, void> glTransformFeedbackVaryingsNV;
#endif
    }
}
#endif