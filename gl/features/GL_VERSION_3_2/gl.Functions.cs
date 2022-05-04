#if (GL_VERSION_3_2 && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_SC_VERSION_2_0)
        /// <summary>GLenum glClientWaitSync(GLsync sync, GLbitfield flags, GLuint64 timeout);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sync, SyncObjectMask, GLuint64, SyncStatus> glClientWaitSync;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDeleteSync(GLsync sync);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sync, void> glDeleteSync;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDrawElementsBaseVertex(GLenum mode, GLsizei count, GLenum type, void* indices, GLint basevertex);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, GLint, void> glDrawElementsBaseVertex;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDrawElementsInstancedBaseVertex(GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei instancecount, GLint basevertex);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, GLsizei, GLint, void> glDrawElementsInstancedBaseVertex;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDrawRangeElementsBaseVertex(GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, void* indices, GLint basevertex);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLuint, GLuint, GLsizei, DrawElementsType, void*, GLint, void> glDrawRangeElementsBaseVertex;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLsync glFenceSync(GLenum condition, GLbitfield flags);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<SyncCondition, SyncBehaviorFlags, sync> glFenceSync;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glFramebufferTexture(GLenum target, GLenum attachment, GLuint texture, GLint level);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, texture, GLint, void> glFramebufferTexture;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetBufferParameteri64v(GLenum target, GLenum pname, GLint64* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, BufferPNameARB, GLint64*, void> glGetBufferParameteri64v;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetInteger64i_v(GLenum target, GLuint index, GLint64* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLint64*, void> glGetInteger64i_v;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetInteger64v(GLenum pname, GLint64* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLint64*, void> glGetInteger64v;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetMultisamplefv(GLenum pname, GLuint index, GLfloat* val);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetMultisamplePNameNV, GLuint, GLfloat*, void> glGetMultisamplefv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetSynciv(GLsync sync, GLenum pname, GLsizei count, GLsizei* length, GLint* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sync, SyncParameterName, GLsizei, GLsizei*, GLint*, void> glGetSynciv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLboolean glIsSync(GLsync sync);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sync, GLboolean> glIsSync;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiDrawElementsBaseVertex(GLenum mode, GLsizei* count, GLenum type, void** indices, GLsizei drawcount, GLint* basevertex);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei*, DrawElementsType, void**, GLsizei, GLint*, void> glMultiDrawElementsBaseVertex;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProvokingVertex(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexProvokingMode, void> glProvokingVertex;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glSampleMaski(GLuint maskNumber, GLbitfield mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLbitfield, void> glSampleMaski;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexImage2DMultisample(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, InternalFormat, GLsizei, GLsizei, GLboolean, void> glTexImage2DMultisample;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexImage3DMultisample(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, InternalFormat, GLsizei, GLsizei, GLsizei, GLboolean, void> glTexImage3DMultisample;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glWaitSync(GLsync sync, GLbitfield flags, GLuint64 timeout);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sync, SyncBehaviorFlags, GLuint64, void> glWaitSync;
#endif
    }
}
#endif