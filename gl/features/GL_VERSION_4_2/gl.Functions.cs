#if (GL_VERSION_4_2 && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBindImageTexture(GLuint unit, GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum access, GLenum format);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, texture, GLint, GLboolean, GLint, BufferAccessARB, InternalFormat, void> glBindImageTexture;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDrawArraysInstancedBaseInstance(GLenum mode, GLint first, GLsizei count, GLsizei instancecount, GLuint baseinstance);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint, GLsizei, GLsizei, GLuint, void> glDrawArraysInstancedBaseInstance;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDrawElementsInstancedBaseInstance(GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei instancecount, GLuint baseinstance);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, PrimitiveType, void*, GLsizei, GLuint, void> glDrawElementsInstancedBaseInstance;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDrawElementsInstancedBaseVertexBaseInstance(GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei instancecount, GLint basevertex, GLuint baseinstance);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, GLsizei, GLint, GLuint, void> glDrawElementsInstancedBaseVertexBaseInstance;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDrawTransformFeedbackInstanced(GLenum mode, GLuint id, GLsizei instancecount);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, transformfeedback, GLsizei, void> glDrawTransformFeedbackInstanced;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDrawTransformFeedbackStreamInstanced(GLenum mode, GLuint id, GLuint stream, GLsizei instancecount);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, transformfeedback, GLuint, GLsizei, void> glDrawTransformFeedbackStreamInstanced;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetActiveAtomicCounterBufferiv(GLuint program, GLuint bufferIndex, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLuint, AtomicCounterBufferPName, GLint*, void> glGetActiveAtomicCounterBufferiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetInternalformativ(GLenum target, GLenum internalformat, GLenum pname, GLsizei count, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, InternalFormat, InternalFormatPName, GLsizei, GLint*, void> glGetInternalformativ;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMemoryBarrier(GLbitfield barriers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MemoryBarrierMask, void> glMemoryBarrier;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexStorage1D(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, void> glTexStorage1D;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexStorage2D(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, void> glTexStorage2D;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexStorage3D(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLsizei, void> glTexStorage3D;
#endif
    }
}
#endif