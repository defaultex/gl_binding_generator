#if (GL_EXT_direct_state_access && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBindMultiTextureEXT(GLenum texunit, GLenum target, GLuint texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, texture, void> glBindMultiTextureEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLenum glCheckNamedFramebufferStatusEXT(GLuint framebuffer, GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, FramebufferTarget, FramebufferStatus> glCheckNamedFramebufferStatusEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glClearNamedBufferDataEXT(GLuint buffer, GLenum internalformat, GLenum format, GLenum type, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, SizedInternalFormat, PixelFormat, PixelType, void*, void> glClearNamedBufferDataEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glClearNamedBufferSubDataEXT(GLuint buffer, GLenum internalformat, GLsizeiptr offset, GLsizeiptr size, GLenum format, GLenum type, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, SizedInternalFormat, GLsizeiptr, GLsizeiptr, PixelFormat, PixelType, void*, void> glClearNamedBufferSubDataEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glClientAttribDefaultEXT(GLbitfield mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClientAttribMask, void> glClientAttribDefaultEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCompressedMultiTexImage1DEXT(GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, void* bits);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, InternalFormat, GLsizei, GLint, GLsizei, void*, void> glCompressedMultiTexImage1DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCompressedMultiTexImage2DEXT(GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, void* bits);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLint, GLsizei, void*, void> glCompressedMultiTexImage2DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCompressedMultiTexImage3DEXT(GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, void* bits);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLsizei, GLint, GLsizei, void*, void> glCompressedMultiTexImage3DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCompressedMultiTexSubImage1DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, void* bits);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, GLint, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedMultiTexSubImage1DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCompressedMultiTexSubImage2DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, void* bits);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, GLint, GLint, GLsizei, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedMultiTexSubImage2DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCompressedMultiTexSubImage3DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, void* bits);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedMultiTexSubImage3DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCompressedTextureImage1DEXT(GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, void* bits);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, GLint, InternalFormat, GLsizei, GLint, GLsizei, void*, void> glCompressedTextureImage1DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCompressedTextureImage2DEXT(GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, void* bits);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLint, GLsizei, void*, void> glCompressedTextureImage2DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCompressedTextureImage3DEXT(GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, void* bits);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLsizei, GLint, GLsizei, void*, void> glCompressedTextureImage3DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCompressedTextureSubImage1DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, void* bits);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, GLint, GLint, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedTextureSubImage1DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCompressedTextureSubImage2DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, void* bits);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, GLint, GLint, GLint, GLsizei, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedTextureSubImage2DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCompressedTextureSubImage3DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, void* bits);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedTextureSubImage3DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCopyMultiTexImage1DEXT(GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLint border);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, InternalFormat, GLint, GLint, GLsizei, GLint, void> glCopyMultiTexImage1DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCopyMultiTexImage2DEXT(GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, InternalFormat, GLint, GLint, GLsizei, GLsizei, GLint, void> glCopyMultiTexImage2DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCopyMultiTexSubImage1DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, GLint, GLint, GLint, GLsizei, void> glCopyMultiTexSubImage1DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCopyMultiTexSubImage2DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei, void> glCopyMultiTexSubImage2DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCopyMultiTexSubImage3DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei, void> glCopyMultiTexSubImage3DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCopyTextureImage1DEXT(GLuint texture, GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLint border);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, GLint, InternalFormat, GLint, GLint, GLsizei, GLint, void> glCopyTextureImage1DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCopyTextureImage2DEXT(GLuint texture, GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, GLint, InternalFormat, GLint, GLint, GLsizei, GLsizei, GLint, void> glCopyTextureImage2DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCopyTextureSubImage1DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, GLint, GLint, GLint, GLint, GLsizei, void> glCopyTextureSubImage1DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCopyTextureSubImage2DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei, void> glCopyTextureSubImage2DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCopyTextureSubImage3DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, GLint, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei, void> glCopyTextureSubImage3DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDisableClientStateiEXT(GLenum array, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glDisableClientStateiEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDisableClientStateIndexedEXT(GLenum array, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glDisableClientStateIndexedEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDisableIndexedEXT(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glDisableIndexedEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDisableVertexArrayAttribEXT(GLuint vaobj, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, GLuint, void> glDisableVertexArrayAttribEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDisableVertexArrayEXT(GLuint vaobj, GLenum array);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, EnableCap, void> glDisableVertexArrayEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEnableClientStateiEXT(GLenum array, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glEnableClientStateiEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEnableClientStateIndexedEXT(GLenum array, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glEnableClientStateIndexedEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEnableIndexedEXT(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glEnableIndexedEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEnableVertexArrayAttribEXT(GLuint vaobj, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, GLuint, void> glEnableVertexArrayAttribEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEnableVertexArrayEXT(GLuint vaobj, GLenum array);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, EnableCap, void> glEnableVertexArrayEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFlushMappedNamedBufferRangeEXT(GLuint buffer, GLintptr offset, GLsizeiptr length);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, GLintptr, GLsizeiptr, void> glFlushMappedNamedBufferRangeEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFramebufferDrawBufferEXT(GLuint framebuffer, GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, DrawBufferMode, void> glFramebufferDrawBufferEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFramebufferDrawBuffersEXT(GLuint framebuffer, GLsizei n, GLenum* bufs);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, GLsizei, DrawBufferMode*, void> glFramebufferDrawBuffersEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFramebufferReadBufferEXT(GLuint framebuffer, GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, ReadBufferMode, void> glFramebufferReadBufferEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGenerateMultiTexMipmapEXT(GLenum texunit, GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, void> glGenerateMultiTexMipmapEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGenerateTextureMipmapEXT(GLuint texture, GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, void> glGenerateTextureMipmapEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetBooleanIndexedvEXT(GLenum target, GLuint index, GLboolean* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, GLboolean*, void> glGetBooleanIndexedvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetCompressedMultiTexImageEXT(GLenum texunit, GLenum target, GLint lod, void* img);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, void*, void> glGetCompressedMultiTexImageEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetCompressedTextureImageEXT(GLuint texture, GLenum target, GLint lod, void* img);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, GLint, void*, void> glGetCompressedTextureImageEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetDoublei_vEXT(GLenum pname, GLuint index, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLdouble*, void> glGetDoublei_vEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetDoubleIndexedvEXT(GLenum target, GLuint index, GLdouble* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLdouble*, void> glGetDoubleIndexedvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetFloati_vEXT(GLenum pname, GLuint index, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLfloat*, void> glGetFloati_vEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetFloatIndexedvEXT(GLenum target, GLuint index, GLfloat* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLfloat*, void> glGetFloatIndexedvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetFramebufferParameterivEXT(GLuint framebuffer, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, GetFramebufferParameter, GLint*, void> glGetFramebufferParameterivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetIntegerIndexedvEXT(GLenum target, GLuint index, GLint* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLint*, void> glGetIntegerIndexedvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetMultiTexEnvfvEXT(GLenum texunit, GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureEnvTarget, TextureEnvParameter, GLfloat*, void> glGetMultiTexEnvfvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetMultiTexEnvivEXT(GLenum texunit, GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureEnvTarget, TextureEnvParameter, GLint*, void> glGetMultiTexEnvivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetMultiTexGendvEXT(GLenum texunit, GLenum coord, GLenum pname, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureCoordName, TextureGenParameter, GLdouble*, void> glGetMultiTexGendvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetMultiTexGenfvEXT(GLenum texunit, GLenum coord, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureCoordName, TextureGenParameter, GLfloat*, void> glGetMultiTexGenfvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetMultiTexGenivEXT(GLenum texunit, GLenum coord, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureCoordName, TextureGenParameter, GLint*, void> glGetMultiTexGenivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetMultiTexImageEXT(GLenum texunit, GLenum target, GLint level, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, PixelFormat, PixelType, void*, void> glGetMultiTexImageEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetMultiTexLevelParameterfvEXT(GLenum texunit, GLenum target, GLint level, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, GetTextureParameter, GLfloat*, void> glGetMultiTexLevelParameterfvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetMultiTexLevelParameterivEXT(GLenum texunit, GLenum target, GLint level, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, GetTextureParameter, GLint*, void> glGetMultiTexLevelParameterivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetMultiTexParameterfvEXT(GLenum texunit, GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GetTextureParameter, GLfloat*, void> glGetMultiTexParameterfvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetMultiTexParameterIivEXT(GLenum texunit, GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GetTextureParameter, GLint*, void> glGetMultiTexParameterIivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetMultiTexParameterIuivEXT(GLenum texunit, GLenum target, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GetTextureParameter, GLuint*, void> glGetMultiTexParameterIuivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetMultiTexParameterivEXT(GLenum texunit, GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GetTextureParameter, GLint*, void> glGetMultiTexParameterivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetNamedBufferParameterivEXT(GLuint buffer, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, BufferPNameARB, GLint*, void> glGetNamedBufferParameterivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetNamedBufferPointervEXT(GLuint buffer, GLenum pname, void** params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, BufferPointerNameARB, void**, void> glGetNamedBufferPointervEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetNamedBufferSubDataEXT(GLuint buffer, GLintptr offset, GLsizeiptr size, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, GLintptr, GLsizeiptr, void*, void> glGetNamedBufferSubDataEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetNamedFramebufferAttachmentParameterivEXT(GLuint framebuffer, GLenum attachment, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, FramebufferAttachment, FramebufferAttachmentParameterName, GLint*, void> glGetNamedFramebufferAttachmentParameterivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetNamedFramebufferParameterivEXT(GLuint framebuffer, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, GetFramebufferParameter, GLint*, void> glGetNamedFramebufferParameterivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetNamedProgramivEXT(GLuint program, GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramTarget, ProgramPropertyARB, GLint*, void> glGetNamedProgramivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetNamedProgramLocalParameterdvEXT(GLuint program, GLenum target, GLuint index, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramTarget, GLuint, GLdouble*, void> glGetNamedProgramLocalParameterdvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetNamedProgramLocalParameterfvEXT(GLuint program, GLenum target, GLuint index, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramTarget, GLuint, GLfloat*, void> glGetNamedProgramLocalParameterfvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetNamedProgramLocalParameterIivEXT(GLuint program, GLenum target, GLuint index, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramTarget, GLuint, GLint*, void> glGetNamedProgramLocalParameterIivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetNamedProgramLocalParameterIuivEXT(GLuint program, GLenum target, GLuint index, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramTarget, GLuint, GLuint*, void> glGetNamedProgramLocalParameterIuivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetNamedProgramStringEXT(GLuint program, GLenum target, GLenum pname, void* string);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramTarget, ProgramStringProperty, void*, void> glGetNamedProgramStringEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetNamedRenderbufferParameterivEXT(GLuint renderbuffer, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<renderbuffer, RenderbufferParameterName, GLint*, void> glGetNamedRenderbufferParameterivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetPointeri_vEXT(GLenum pname, GLuint index, void** params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, void**, void> glGetPointeri_vEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetPointerIndexedvEXT(GLenum target, GLuint index, void** data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, void**, void> glGetPointerIndexedvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetTextureImageEXT(GLuint texture, GLenum target, GLint level, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, GLint, PixelFormat, PixelType, void*, void> glGetTextureImageEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetTextureLevelParameterfvEXT(GLuint texture, GLenum target, GLint level, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, GLint, GetTextureParameter, GLfloat*, void> glGetTextureLevelParameterfvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetTextureLevelParameterivEXT(GLuint texture, GLenum target, GLint level, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, GLint, GetTextureParameter, GLint*, void> glGetTextureLevelParameterivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetTextureParameterfvEXT(GLuint texture, GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, GetTextureParameter, GLfloat*, void> glGetTextureParameterfvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetTextureParameterIivEXT(GLuint texture, GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, GetTextureParameter, GLint*, void> glGetTextureParameterIivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetTextureParameterIuivEXT(GLuint texture, GLenum target, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, GetTextureParameter, GLuint*, void> glGetTextureParameterIuivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetTextureParameterivEXT(GLuint texture, GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, GetTextureParameter, GLint*, void> glGetTextureParameterivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetVertexArrayIntegeri_vEXT(GLuint vaobj, GLuint index, GLenum pname, GLint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, GLuint, VertexArrayPName, GLint*, void> glGetVertexArrayIntegeri_vEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetVertexArrayIntegervEXT(GLuint vaobj, GLenum pname, GLint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, VertexArrayPName, GLint*, void> glGetVertexArrayIntegervEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetVertexArrayPointeri_vEXT(GLuint vaobj, GLuint index, GLenum pname, void** param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, GLuint, VertexArrayPName, void**, void> glGetVertexArrayPointeri_vEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetVertexArrayPointervEXT(GLuint vaobj, GLenum pname, void** param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, VertexArrayPName, void**, void> glGetVertexArrayPointervEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsEnabledIndexedEXT(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, GLboolean> glIsEnabledIndexedEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void* glMapNamedBufferEXT(GLuint buffer, GLenum access);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, BufferAccessARB, void*> glMapNamedBufferEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void* glMapNamedBufferRangeEXT(GLuint buffer, GLintptr offset, GLsizeiptr length, GLbitfield access);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, GLintptr, GLsizeiptr, MapBufferAccessMask, void*> glMapNamedBufferRangeEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixFrustumEXT(GLenum mode, GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble, GLdouble, GLdouble, GLdouble, GLdouble, GLdouble, void> glMatrixFrustumEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixLoaddEXT(GLenum mode, GLdouble* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble*, void> glMatrixLoaddEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixLoadfEXT(GLenum mode, GLfloat* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLfloat*, void> glMatrixLoadfEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixLoadIdentityEXT(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, void> glMatrixLoadIdentityEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixLoadTransposedEXT(GLenum mode, GLdouble* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble*, void> glMatrixLoadTransposedEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixLoadTransposefEXT(GLenum mode, GLfloat* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLfloat*, void> glMatrixLoadTransposefEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixMultdEXT(GLenum mode, GLdouble* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble*, void> glMatrixMultdEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixMultfEXT(GLenum mode, GLfloat* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLfloat*, void> glMatrixMultfEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixMultTransposedEXT(GLenum mode, GLdouble* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble*, void> glMatrixMultTransposedEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixMultTransposefEXT(GLenum mode, GLfloat* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLfloat*, void> glMatrixMultTransposefEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixOrthoEXT(GLenum mode, GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble, GLdouble, GLdouble, GLdouble, GLdouble, GLdouble, void> glMatrixOrthoEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixPopEXT(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, void> glMatrixPopEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixPushEXT(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, void> glMatrixPushEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixRotatedEXT(GLenum mode, GLdouble angle, GLdouble x, GLdouble y, GLdouble z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble, GLdouble, GLdouble, GLdouble, void> glMatrixRotatedEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixRotatefEXT(GLenum mode, GLfloat angle, GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLfloat, GLfloat, GLfloat, GLfloat, void> glMatrixRotatefEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixScaledEXT(GLenum mode, GLdouble x, GLdouble y, GLdouble z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble, GLdouble, GLdouble, void> glMatrixScaledEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixScalefEXT(GLenum mode, GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLfloat, GLfloat, GLfloat, void> glMatrixScalefEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixTranslatedEXT(GLenum mode, GLdouble x, GLdouble y, GLdouble z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble, GLdouble, GLdouble, void> glMatrixTranslatedEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMatrixTranslatefEXT(GLenum mode, GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLfloat, GLfloat, GLfloat, void> glMatrixTranslatefEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexBufferEXT(GLenum texunit, GLenum target, GLenum internalformat, GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, InternalFormat, buffer, void> glMultiTexBufferEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoordPointerEXT(GLenum texunit, GLint size, GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLint, TexCoordPointerType, GLsizei, void*, void> glMultiTexCoordPointerEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexEnvfEXT(GLenum texunit, GLenum target, GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureEnvTarget, TextureEnvParameter, GLfloat, void> glMultiTexEnvfEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexEnvfvEXT(GLenum texunit, GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureEnvTarget, TextureEnvParameter, GLfloat*, void> glMultiTexEnvfvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexEnviEXT(GLenum texunit, GLenum target, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureEnvTarget, TextureEnvParameter, GLint, void> glMultiTexEnviEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexEnvivEXT(GLenum texunit, GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureEnvTarget, TextureEnvParameter, GLint*, void> glMultiTexEnvivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexGendEXT(GLenum texunit, GLenum coord, GLenum pname, GLdouble param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureCoordName, TextureGenParameter, GLdouble, void> glMultiTexGendEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexGendvEXT(GLenum texunit, GLenum coord, GLenum pname, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureCoordName, TextureGenParameter, GLdouble*, void> glMultiTexGendvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexGenfEXT(GLenum texunit, GLenum coord, GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureCoordName, TextureGenParameter, GLfloat, void> glMultiTexGenfEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexGenfvEXT(GLenum texunit, GLenum coord, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureCoordName, TextureGenParameter, GLfloat*, void> glMultiTexGenfvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexGeniEXT(GLenum texunit, GLenum coord, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureCoordName, TextureGenParameter, GLint, void> glMultiTexGeniEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexGenivEXT(GLenum texunit, GLenum coord, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureCoordName, TextureGenParameter, GLint*, void> glMultiTexGenivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexImage1DEXT(GLenum texunit, GLenum target, GLint level, GLint internalformat, GLsizei width, GLint border, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, InternalFormat, GLsizei, GLint, PixelFormat, PixelType, void*, void> glMultiTexImage1DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexImage2DEXT(GLenum texunit, GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLint, PixelFormat, PixelType, void*, void> glMultiTexImage2DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexImage3DEXT(GLenum texunit, GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLsizei, GLint, PixelFormat, PixelType, void*, void> glMultiTexImage3DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexParameterfEXT(GLenum texunit, GLenum target, GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, TextureParameterName, GLfloat, void> glMultiTexParameterfEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexParameterfvEXT(GLenum texunit, GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, TextureParameterName, GLfloat*, void> glMultiTexParameterfvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexParameteriEXT(GLenum texunit, GLenum target, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, TextureParameterName, GLint, void> glMultiTexParameteriEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexParameterIivEXT(GLenum texunit, GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, TextureParameterName, GLint*, void> glMultiTexParameterIivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexParameterIuivEXT(GLenum texunit, GLenum target, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, TextureParameterName, GLuint*, void> glMultiTexParameterIuivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexParameterivEXT(GLenum texunit, GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, TextureParameterName, GLint*, void> glMultiTexParameterivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexRenderbufferEXT(GLenum texunit, GLenum target, GLuint renderbuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, renderbuffer, void> glMultiTexRenderbufferEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexSubImage1DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, GLint, GLsizei, PixelFormat, PixelType, void*, void> glMultiTexSubImage1DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexSubImage2DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glMultiTexSubImage2DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexSubImage3DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glMultiTexSubImage3DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedBufferDataEXT(GLuint buffer, GLsizeiptr size, void* data, GLenum usage);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, GLsizeiptr, void*, VertexBufferObjectUsage, void> glNamedBufferDataEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedBufferStorageEXT(GLuint buffer, GLsizeiptr size, void* data, GLbitfield flags);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, GLsizeiptr, void*, BufferStorageMask, void> glNamedBufferStorageEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedBufferSubDataEXT(GLuint buffer, GLintptr offset, GLsizeiptr size, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, GLintptr, GLsizeiptr, void*, void> glNamedBufferSubDataEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedCopyBufferSubDataEXT(GLuint readBuffer, GLuint writeBuffer, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, buffer, GLintptr, GLintptr, GLsizeiptr, void> glNamedCopyBufferSubDataEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedFramebufferParameteriEXT(GLuint framebuffer, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, FramebufferParameterName, GLint, void> glNamedFramebufferParameteriEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedFramebufferRenderbufferEXT(GLuint framebuffer, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, FramebufferAttachment, RenderbufferTarget, renderbuffer, void> glNamedFramebufferRenderbufferEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedFramebufferTexture1DEXT(GLuint framebuffer, GLenum attachment, GLenum textarget, GLuint texture, GLint level);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, FramebufferAttachment, TextureTarget, texture, GLint, void> glNamedFramebufferTexture1DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedFramebufferTexture2DEXT(GLuint framebuffer, GLenum attachment, GLenum textarget, GLuint texture, GLint level);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, FramebufferAttachment, TextureTarget, texture, GLint, void> glNamedFramebufferTexture2DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedFramebufferTexture3DEXT(GLuint framebuffer, GLenum attachment, GLenum textarget, GLuint texture, GLint level, GLint zoffset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, FramebufferAttachment, TextureTarget, texture, GLint, GLint, void> glNamedFramebufferTexture3DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedFramebufferTextureEXT(GLuint framebuffer, GLenum attachment, GLuint texture, GLint level);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, FramebufferAttachment, texture, GLint, void> glNamedFramebufferTextureEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedFramebufferTextureFaceEXT(GLuint framebuffer, GLenum attachment, GLuint texture, GLint level, GLenum face);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, FramebufferAttachment, texture, GLint, TextureTarget, void> glNamedFramebufferTextureFaceEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedFramebufferTextureLayerEXT(GLuint framebuffer, GLenum attachment, GLuint texture, GLint level, GLint layer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, FramebufferAttachment, texture, GLint, GLint, void> glNamedFramebufferTextureLayerEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedProgramLocalParameter4dEXT(GLuint program, GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramTarget, GLuint, GLdouble, GLdouble, GLdouble, GLdouble, void> glNamedProgramLocalParameter4dEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedProgramLocalParameter4dvEXT(GLuint program, GLenum target, GLuint index, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramTarget, GLuint, GLdouble*, void> glNamedProgramLocalParameter4dvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedProgramLocalParameter4fEXT(GLuint program, GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramTarget, GLuint, GLfloat, GLfloat, GLfloat, GLfloat, void> glNamedProgramLocalParameter4fEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedProgramLocalParameter4fvEXT(GLuint program, GLenum target, GLuint index, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramTarget, GLuint, GLfloat*, void> glNamedProgramLocalParameter4fvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedProgramLocalParameterI4iEXT(GLuint program, GLenum target, GLuint index, GLint x, GLint y, GLint z, GLint w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramTarget, GLuint, GLint, GLint, GLint, GLint, void> glNamedProgramLocalParameterI4iEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedProgramLocalParameterI4ivEXT(GLuint program, GLenum target, GLuint index, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramTarget, GLuint, GLint*, void> glNamedProgramLocalParameterI4ivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedProgramLocalParameterI4uiEXT(GLuint program, GLenum target, GLuint index, GLuint x, GLuint y, GLuint z, GLuint w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramTarget, GLuint, GLuint, GLuint, GLuint, GLuint, void> glNamedProgramLocalParameterI4uiEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedProgramLocalParameterI4uivEXT(GLuint program, GLenum target, GLuint index, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramTarget, GLuint, GLuint*, void> glNamedProgramLocalParameterI4uivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedProgramLocalParameters4fvEXT(GLuint program, GLenum target, GLuint index, GLsizei count, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramTarget, GLuint, GLsizei, GLfloat*, void> glNamedProgramLocalParameters4fvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedProgramLocalParametersI4ivEXT(GLuint program, GLenum target, GLuint index, GLsizei count, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramTarget, GLuint, GLsizei, GLint*, void> glNamedProgramLocalParametersI4ivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedProgramLocalParametersI4uivEXT(GLuint program, GLenum target, GLuint index, GLsizei count, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramTarget, GLuint, GLsizei, GLuint*, void> glNamedProgramLocalParametersI4uivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedProgramStringEXT(GLuint program, GLenum target, GLenum format, GLsizei len, void* string);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramTarget, ProgramFormat, GLsizei, void*, void> glNamedProgramStringEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedRenderbufferStorageEXT(GLuint renderbuffer, GLenum internalformat, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<renderbuffer, InternalFormat, GLsizei, GLsizei, void> glNamedRenderbufferStorageEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedRenderbufferStorageMultisampleCoverageEXT(GLuint renderbuffer, GLsizei coverageSamples, GLsizei colorSamples, GLenum internalformat, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<renderbuffer, GLsizei, GLsizei, InternalFormat, GLsizei, GLsizei, void> glNamedRenderbufferStorageMultisampleCoverageEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedRenderbufferStorageMultisampleEXT(GLuint renderbuffer, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<renderbuffer, GLsizei, InternalFormat, GLsizei, GLsizei, void> glNamedRenderbufferStorageMultisampleEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform1dEXT(GLuint program, GLint location, GLdouble x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLdouble, void> glProgramUniform1dEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform1dvEXT(GLuint program, GLint location, GLsizei count, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLdouble*, void> glProgramUniform1dvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform1fEXT(GLuint program, GLint location, GLfloat v0);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLfloat, void> glProgramUniform1fEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform1fvEXT(GLuint program, GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLfloat*, void> glProgramUniform1fvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform1iEXT(GLuint program, GLint location, GLint v0);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLint, void> glProgramUniform1iEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform1ivEXT(GLuint program, GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLint*, void> glProgramUniform1ivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform1uiEXT(GLuint program, GLint location, GLuint v0);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLuint, void> glProgramUniform1uiEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform1uivEXT(GLuint program, GLint location, GLsizei count, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLuint*, void> glProgramUniform1uivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform2dEXT(GLuint program, GLint location, GLdouble x, GLdouble y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLdouble, GLdouble, void> glProgramUniform2dEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform2dvEXT(GLuint program, GLint location, GLsizei count, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLdouble*, void> glProgramUniform2dvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform2fEXT(GLuint program, GLint location, GLfloat v0, GLfloat v1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLfloat, GLfloat, void> glProgramUniform2fEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform2fvEXT(GLuint program, GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLfloat*, void> glProgramUniform2fvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform2iEXT(GLuint program, GLint location, GLint v0, GLint v1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLint, GLint, void> glProgramUniform2iEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform2ivEXT(GLuint program, GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLint*, void> glProgramUniform2ivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform2uiEXT(GLuint program, GLint location, GLuint v0, GLuint v1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLuint, GLuint, void> glProgramUniform2uiEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform2uivEXT(GLuint program, GLint location, GLsizei count, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLuint*, void> glProgramUniform2uivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform3dEXT(GLuint program, GLint location, GLdouble x, GLdouble y, GLdouble z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLdouble, GLdouble, GLdouble, void> glProgramUniform3dEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform3dvEXT(GLuint program, GLint location, GLsizei count, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLdouble*, void> glProgramUniform3dvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform3fEXT(GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLfloat, GLfloat, GLfloat, void> glProgramUniform3fEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform3fvEXT(GLuint program, GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLfloat*, void> glProgramUniform3fvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform3iEXT(GLuint program, GLint location, GLint v0, GLint v1, GLint v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLint, GLint, GLint, void> glProgramUniform3iEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform3ivEXT(GLuint program, GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLint*, void> glProgramUniform3ivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform3uiEXT(GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLuint, GLuint, GLuint, void> glProgramUniform3uiEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform3uivEXT(GLuint program, GLint location, GLsizei count, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLuint*, void> glProgramUniform3uivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform4dEXT(GLuint program, GLint location, GLdouble x, GLdouble y, GLdouble z, GLdouble w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLdouble, GLdouble, GLdouble, GLdouble, void> glProgramUniform4dEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform4dvEXT(GLuint program, GLint location, GLsizei count, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLdouble*, void> glProgramUniform4dvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform4fEXT(GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLfloat, GLfloat, GLfloat, GLfloat, void> glProgramUniform4fEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform4fvEXT(GLuint program, GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLfloat*, void> glProgramUniform4fvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform4iEXT(GLuint program, GLint location, GLint v0, GLint v1, GLint v2, GLint v3);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLint, GLint, GLint, GLint, void> glProgramUniform4iEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform4ivEXT(GLuint program, GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLint*, void> glProgramUniform4ivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform4uiEXT(GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLuint, GLuint, GLuint, GLuint, void> glProgramUniform4uiEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform4uivEXT(GLuint program, GLint location, GLsizei count, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLuint*, void> glProgramUniform4uivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniformMatrix2dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix2dvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniformMatrix2fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix2fvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniformMatrix2x3dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix2x3dvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniformMatrix2x3fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix2x3fvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniformMatrix2x4dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix2x4dvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniformMatrix2x4fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix2x4fvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniformMatrix3dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix3dvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniformMatrix3fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix3fvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniformMatrix3x2dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix3x2dvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniformMatrix3x2fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix3x2fvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniformMatrix3x4dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix3x4dvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniformMatrix3x4fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix3x4fvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniformMatrix4dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix4dvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniformMatrix4fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix4fvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniformMatrix4x2dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix4x2dvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniformMatrix4x2fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix4x2fvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniformMatrix4x3dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix4x3dvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniformMatrix4x3fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix4x3fvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPushClientAttribDefaultEXT(GLbitfield mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClientAttribMask, void> glPushClientAttribDefaultEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureBufferEXT(GLuint texture, GLenum target, GLenum internalformat, GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, SizedInternalFormat, buffer, void> glTextureBufferEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureBufferRangeEXT(GLuint texture, GLenum target, GLenum internalformat, GLuint buffer, GLintptr offset, GLsizeiptr size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, SizedInternalFormat, buffer, GLintptr, GLsizeiptr, void> glTextureBufferRangeEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureImage1DEXT(GLuint texture, GLenum target, GLint level, GLint internalformat, GLsizei width, GLint border, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, GLint, InternalFormat, GLsizei, GLint, PixelFormat, PixelType, void*, void> glTextureImage1DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureImage2DEXT(GLuint texture, GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLint, PixelFormat, PixelType, void*, void> glTextureImage2DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureImage3DEXT(GLuint texture, GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLsizei, GLint, PixelFormat, PixelType, void*, void> glTextureImage3DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexturePageCommitmentEXT(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLboolean commit);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, GLboolean, void> glTexturePageCommitmentEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureParameterfEXT(GLuint texture, GLenum target, GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, TextureParameterName, GLfloat, void> glTextureParameterfEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureParameterfvEXT(GLuint texture, GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, TextureParameterName, GLfloat*, void> glTextureParameterfvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureParameteriEXT(GLuint texture, GLenum target, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, TextureParameterName, GLint, void> glTextureParameteriEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureParameterIivEXT(GLuint texture, GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, TextureParameterName, GLint*, void> glTextureParameterIivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureParameterIuivEXT(GLuint texture, GLenum target, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, TextureParameterName, GLuint*, void> glTextureParameterIuivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureParameterivEXT(GLuint texture, GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, TextureParameterName, GLint*, void> glTextureParameterivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureRenderbufferEXT(GLuint texture, GLenum target, GLuint renderbuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, renderbuffer, void> glTextureRenderbufferEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureStorage1DEXT(GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLenum, GLsizei, SizedInternalFormat, GLsizei, void> glTextureStorage1DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureStorage2DEXT(GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLenum, GLsizei, SizedInternalFormat, GLsizei, GLsizei, void> glTextureStorage2DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureStorage2DMultisampleEXT(GLuint texture, GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLboolean, void> glTextureStorage2DMultisampleEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureStorage3DEXT(GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLenum, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLsizei, void> glTextureStorage3DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureStorage3DMultisampleEXT(GLuint texture, GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLenum, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLsizei, GLboolean, void> glTextureStorage3DMultisampleEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureSubImage1DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, GLint, GLint, GLsizei, PixelFormat, PixelType, void*, void> glTextureSubImage1DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureSubImage2DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, GLint, GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glTextureSubImage2DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureSubImage3DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glTextureSubImage3DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glUnmapNamedBufferEXT(GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, GLboolean> glUnmapNamedBufferEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexArrayBindVertexBufferEXT(GLuint vaobj, GLuint bindingindex, GLuint buffer, GLintptr offset, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, GLuint, buffer, GLintptr, GLsizei, void> glVertexArrayBindVertexBufferEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexArrayColorOffsetEXT(GLuint vaobj, GLuint buffer, GLint size, GLenum type, GLsizei stride, GLintptr offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, buffer, GLint, ColorPointerType, GLsizei, GLintptr, void> glVertexArrayColorOffsetEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexArrayEdgeFlagOffsetEXT(GLuint vaobj, GLuint buffer, GLsizei stride, GLintptr offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, buffer, GLsizei, GLintptr, void> glVertexArrayEdgeFlagOffsetEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexArrayFogCoordOffsetEXT(GLuint vaobj, GLuint buffer, GLenum type, GLsizei stride, GLintptr offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, buffer, FogCoordinatePointerType, GLsizei, GLintptr, void> glVertexArrayFogCoordOffsetEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexArrayIndexOffsetEXT(GLuint vaobj, GLuint buffer, GLenum type, GLsizei stride, GLintptr offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, buffer, IndexPointerType, GLsizei, GLintptr, void> glVertexArrayIndexOffsetEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexArrayMultiTexCoordOffsetEXT(GLuint vaobj, GLuint buffer, GLenum texunit, GLint size, GLenum type, GLsizei stride, GLintptr offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, buffer, GLenum, GLint, TexCoordPointerType, GLsizei, GLintptr, void> glVertexArrayMultiTexCoordOffsetEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexArrayNormalOffsetEXT(GLuint vaobj, GLuint buffer, GLenum type, GLsizei stride, GLintptr offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, buffer, NormalPointerType, GLsizei, GLintptr, void> glVertexArrayNormalOffsetEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexArraySecondaryColorOffsetEXT(GLuint vaobj, GLuint buffer, GLint size, GLenum type, GLsizei stride, GLintptr offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, buffer, GLint, ColorPointerType, GLsizei, GLintptr, void> glVertexArraySecondaryColorOffsetEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexArrayTexCoordOffsetEXT(GLuint vaobj, GLuint buffer, GLint size, GLenum type, GLsizei stride, GLintptr offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, buffer, GLint, TexCoordPointerType, GLsizei, GLintptr, void> glVertexArrayTexCoordOffsetEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexArrayVertexAttribBindingEXT(GLuint vaobj, GLuint attribindex, GLuint bindingindex);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, GLuint, GLuint, void> glVertexArrayVertexAttribBindingEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexArrayVertexAttribDivisorEXT(GLuint vaobj, GLuint index, GLuint divisor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, GLuint, GLuint, void> glVertexArrayVertexAttribDivisorEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexArrayVertexAttribFormatEXT(GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLboolean normalized, GLuint relativeoffset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, GLuint, GLint, VertexAttribType, GLboolean, GLuint, void> glVertexArrayVertexAttribFormatEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexArrayVertexAttribIFormatEXT(GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, GLuint, GLint, VertexAttribIType, GLuint, void> glVertexArrayVertexAttribIFormatEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexArrayVertexAttribIOffsetEXT(GLuint vaobj, GLuint buffer, GLuint index, GLint size, GLenum type, GLsizei stride, GLintptr offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, buffer, GLuint, GLint, VertexAttribType, GLsizei, GLintptr, void> glVertexArrayVertexAttribIOffsetEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexArrayVertexAttribLFormatEXT(GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, GLuint, GLint, VertexAttribLType, GLuint, void> glVertexArrayVertexAttribLFormatEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexArrayVertexAttribLOffsetEXT(GLuint vaobj, GLuint buffer, GLuint index, GLint size, GLenum type, GLsizei stride, GLintptr offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, buffer, GLuint, GLint, VertexAttribLType, GLsizei, GLintptr, void> glVertexArrayVertexAttribLOffsetEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexArrayVertexAttribOffsetEXT(GLuint vaobj, GLuint buffer, GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride, GLintptr offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, buffer, GLuint, GLint, VertexAttribPointerType, GLboolean, GLsizei, GLintptr, void> glVertexArrayVertexAttribOffsetEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexArrayVertexBindingDivisorEXT(GLuint vaobj, GLuint bindingindex, GLuint divisor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, GLuint, GLuint, void> glVertexArrayVertexBindingDivisorEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexArrayVertexOffsetEXT(GLuint vaobj, GLuint buffer, GLint size, GLenum type, GLsizei stride, GLintptr offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, buffer, GLint, VertexPointerType, GLsizei, GLintptr, void> glVertexArrayVertexOffsetEXT;
#endif
    }
}
#endif