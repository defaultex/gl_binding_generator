#if (GL_EXT_transform_feedback && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBeginTransformFeedbackEXT(GLenum primitiveMode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, void> glBeginTransformFeedbackEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBindBufferBaseEXT(GLenum target, GLuint index, GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, buffer, void> glBindBufferBaseEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBindBufferOffsetEXT(GLenum target, GLuint index, GLuint buffer, GLintptr offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, buffer, GLintptr, void> glBindBufferOffsetEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBindBufferRangeEXT(GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, buffer, GLintptr, GLsizeiptr, void> glBindBufferRangeEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEndTransformFeedbackEXT();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glEndTransformFeedbackEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetTransformFeedbackVaryingEXT(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLsizei* size, GLenum* type, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLuint, GLsizei, GLsizei*, GLsizei*, AttributeType*, GLchar*, void> glGetTransformFeedbackVaryingEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTransformFeedbackVaryingsEXT(GLuint program, GLsizei count, GLchar** varyings, GLenum bufferMode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLsizei, GLchar**, GLenum, void> glTransformFeedbackVaryingsEXT;
#endif
    }
}
#endif