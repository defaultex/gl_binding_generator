#if (GL_VERSION_1_1 && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>GLboolean glAreTexturesResident(GLsizei n, GLuint* textures, GLboolean* residences);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLtexture*, GLboolean*, GLboolean> glAreTexturesResident;

        /// <summary>void glArrayElement(GLint i);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, void> glArrayElement;

        /// <summary>void glBindTexture(GLenum target, GLuint texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLtexture, void> glBindTexture;

        /// <summary>void glColorPointer(GLint size, GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, ColorPointerType, GLsizei, void*, void> glColorPointer;

        /// <summary>void glCopyTexImage1D(GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLint border);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLint, GLint, GLsizei, GLint, void> glCopyTexImage1D;

        /// <summary>void glCopyTexImage2D(GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLint, GLint, GLsizei, GLsizei, GLint, void> glCopyTexImage2D;

        /// <summary>void glCopyTexSubImage1D(GLenum target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLint, GLsizei, void> glCopyTexSubImage1D;

        /// <summary>void glCopyTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei, void> glCopyTexSubImage2D;

        /// <summary>void glDeleteTextures(GLsizei n, GLuint* textures);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLtexture*, void> glDeleteTextures;

        /// <summary>void glDisableClientState(GLenum array);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, void> glDisableClientState;

        /// <summary>void glDrawArrays(GLenum mode, GLint first, GLsizei count);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint, GLsizei, void> glDrawArrays;

        /// <summary>void glDrawElements(GLenum mode, GLsizei count, GLenum type, void* indices);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, void> glDrawElements;

        /// <summary>void glEdgeFlagPointer(GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, void*, void> glEdgeFlagPointer;

        /// <summary>void glEnableClientState(GLenum array);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, void> glEnableClientState;

        /// <summary>void glGenTextures(GLsizei n, GLuint* textures);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLtexture*, void> glGenTextures;

        /// <summary>void glGetPointerv(GLenum pname, void** params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPointervPName, void**, void> glGetPointerv;

        /// <summary>void glIndexPointer(GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<IndexPointerType, GLsizei, void*, void> glIndexPointer;

        /// <summary>void glIndexub(GLubyte c);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte, void> glIndexub;

        /// <summary>void glIndexubv(GLubyte* c);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte*, void> glIndexubv;

        /// <summary>void glInterleavedArrays(GLenum format, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<InterleavedArrayFormat, GLsizei, void*, void> glInterleavedArrays;

        /// <summary>GLboolean glIsTexture(GLuint texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLboolean> glIsTexture;

        /// <summary>void glNormalPointer(GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<NormalPointerType, GLsizei, void*, void> glNormalPointer;

        /// <summary>void glPolygonOffset(GLfloat factor, GLfloat units);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glPolygonOffset;

        /// <summary>void glPopClientAttrib();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPopClientAttrib;

        /// <summary>void glPrioritizeTextures(GLsizei n, GLuint* textures, GLfloat* priorities);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLtexture*, GLfloat*, void> glPrioritizeTextures;

        /// <summary>void glPushClientAttrib(GLbitfield mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClientAttribMask, void> glPushClientAttrib;

        /// <summary>void glTexCoordPointer(GLint size, GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, TexCoordPointerType, GLsizei, void*, void> glTexCoordPointer;

        /// <summary>void glTexSubImage1D(GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLsizei, PixelFormat, PixelType, void*, void> glTexSubImage1D;

        /// <summary>void glTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glTexSubImage2D;

        /// <summary>void glVertexPointer(GLint size, GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, VertexPointerType, GLsizei, void*, void> glVertexPointer;
    }
}
#endif