#if (GL_VERSION_3_2 && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>GLenum glClientWaitSync(GLsync sync, GLbitfield flags, GLuint64 timeout);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsync, SyncObjectMask, GLuint64, SyncStatus> glClientWaitSync;

        /// <summary>void glDeleteSync(GLsync sync);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsync, void> glDeleteSync;

        /// <summary>void glDrawElementsBaseVertex(GLenum mode, GLsizei count, GLenum type, void* indices, GLint basevertex);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, GLint, void> glDrawElementsBaseVertex;

        /// <summary>void glDrawElementsInstancedBaseVertex(GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei instancecount, GLint basevertex);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, GLsizei, GLint, void> glDrawElementsInstancedBaseVertex;

        /// <summary>void glDrawRangeElementsBaseVertex(GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, void* indices, GLint basevertex);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLuint, GLuint, GLsizei, DrawElementsType, void*, GLint, void> glDrawRangeElementsBaseVertex;

        /// <summary>GLsync glFenceSync(GLenum condition, GLbitfield flags);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<SyncCondition, SyncBehaviorFlags, GLsync> glFenceSync;

        /// <summary>void glFramebufferTexture(GLenum target, GLenum attachment, GLuint texture, GLint level);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, GLtexture, GLint, void> glFramebufferTexture;

        /// <summary>void glGetBufferParameteri64v(GLenum target, GLenum pname, GLint64* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, BufferPNameARB, GLint64*, void> glGetBufferParameteri64v;

        /// <summary>void glGetInteger64i_v(GLenum target, GLuint index, GLint64* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLint64*, void> glGetInteger64i_v;

        /// <summary>void glGetInteger64v(GLenum pname, GLint64* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLint64*, void> glGetInteger64v;

        /// <summary>void glGetMultisamplefv(GLenum pname, GLuint index, GLfloat* val);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetMultisamplePNameNV, GLuint, GLfloat*, void> glGetMultisamplefv;

        /// <summary>void glGetSynciv(GLsync sync, GLenum pname, GLsizei count, GLsizei* length, GLint* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsync, SyncParameterName, GLsizei, GLsizei*, GLint*, void> glGetSynciv;

        /// <summary>GLboolean glIsSync(GLsync sync);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsync, GLboolean> glIsSync;

        /// <summary>void glMultiDrawElementsBaseVertex(GLenum mode, GLsizei* count, GLenum type, void** indices, GLsizei drawcount, GLint* basevertex);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei*, DrawElementsType, void**, GLsizei, GLint*, void> glMultiDrawElementsBaseVertex;

        /// <summary>void glProvokingVertex(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexProvokingMode, void> glProvokingVertex;

        /// <summary>void glSampleMaski(GLuint maskNumber, GLbitfield mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLbitfield, void> glSampleMaski;

        /// <summary>void glTexImage2DMultisample(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, InternalFormat, GLsizei, GLsizei, GLboolean, void> glTexImage2DMultisample;

        /// <summary>void glTexImage3DMultisample(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, InternalFormat, GLsizei, GLsizei, GLsizei, GLboolean, void> glTexImage3DMultisample;

        /// <summary>void glWaitSync(GLsync sync, GLbitfield flags, GLuint64 timeout);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsync, SyncBehaviorFlags, GLuint64, void> glWaitSync;
    }
}
#endif