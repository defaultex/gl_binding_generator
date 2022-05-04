#if (GL_VERSION_1_1 && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_SC_VERSION_2_0)
        /// <summary>GLboolean glAreTexturesResident(GLsizei n, GLuint* textures, GLboolean* residences);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, texture*, GLboolean*, GLboolean> glAreTexturesResident;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glArrayElement(GLint i);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, void> glArrayElement;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBindTexture(GLenum target, GLuint texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, texture, void> glBindTexture;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColorPointer(GLint size, GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, ColorPointerType, GLsizei, void*, void> glColorPointer;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glCopyTexImage1D(GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLint border);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLint, GLint, GLsizei, GLint, void> glCopyTexImage1D;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glCopyTexImage2D(GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLint, GLint, GLsizei, GLsizei, GLint, void> glCopyTexImage2D;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glCopyTexSubImage1D(GLenum target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLint, GLsizei, void> glCopyTexSubImage1D;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glCopyTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei, void> glCopyTexSubImage2D;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDeleteTextures(GLsizei n, GLuint* textures);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, texture*, void> glDeleteTextures;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDisableClientState(GLenum array);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, void> glDisableClientState;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDrawArrays(GLenum mode, GLint first, GLsizei count);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint, GLsizei, void> glDrawArrays;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDrawElements(GLenum mode, GLsizei count, GLenum type, void* indices);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, void> glDrawElements;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glEdgeFlagPointer(GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, void*, void> glEdgeFlagPointer;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glEnableClientState(GLenum array);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, void> glEnableClientState;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGenTextures(GLsizei n, GLuint* textures);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, texture*, void> glGenTextures;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetPointerv(GLenum pname, void** params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPointervPName, void**, void> glGetPointerv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glIndexPointer(GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<IndexPointerType, GLsizei, void*, void> glIndexPointer;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glIndexub(GLubyte c);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte, void> glIndexub;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glIndexubv(GLubyte* c);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte*, void> glIndexubv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glInterleavedArrays(GLenum format, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<InterleavedArrayFormat, GLsizei, void*, void> glInterleavedArrays;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLboolean glIsTexture(GLuint texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLboolean> glIsTexture;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glNormalPointer(GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<NormalPointerType, GLsizei, void*, void> glNormalPointer;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glPolygonOffset(GLfloat factor, GLfloat units);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glPolygonOffset;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glPopClientAttrib();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPopClientAttrib;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glPrioritizeTextures(GLsizei n, GLuint* textures, GLfloat* priorities);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, texture*, GLfloat*, void> glPrioritizeTextures;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glPushClientAttrib(GLbitfield mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClientAttribMask, void> glPushClientAttrib;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoordPointer(GLint size, GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, TexCoordPointerType, GLsizei, void*, void> glTexCoordPointer;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexSubImage1D(GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLsizei, PixelFormat, PixelType, void*, void> glTexSubImage1D;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glTexSubImage2D;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexPointer(GLint size, GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, VertexPointerType, GLsizei, void*, void> glVertexPointer;
#endif
    }
}
#endif