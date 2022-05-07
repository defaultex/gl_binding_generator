#if (GL_EXT_direct_state_access && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBindMultiTextureEXT(GLenum texunit, GLenum target, GLuint texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLtexture, void> glBindMultiTextureEXT;

        /// <summary>GLenum glCheckNamedFramebufferStatusEXT(GLuint framebuffer, GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, FramebufferTarget, FramebufferStatus> glCheckNamedFramebufferStatusEXT;

        /// <summary>void glClearNamedBufferDataEXT(GLuint buffer, GLenum internalformat, GLenum format, GLenum type, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, SizedInternalFormat, PixelFormat, PixelType, void*, void> glClearNamedBufferDataEXT;

        /// <summary>void glClearNamedBufferSubDataEXT(GLuint buffer, GLenum internalformat, GLsizeiptr offset, GLsizeiptr size, GLenum format, GLenum type, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, SizedInternalFormat, GLsizeiptr, GLsizeiptr, PixelFormat, PixelType, void*, void> glClearNamedBufferSubDataEXT;

        /// <summary>void glClientAttribDefaultEXT(GLbitfield mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClientAttribMask, void> glClientAttribDefaultEXT;

        /// <summary>void glCompressedMultiTexImage1DEXT(GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, void* bits);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, InternalFormat, GLsizei, GLint, GLsizei, void*, void> glCompressedMultiTexImage1DEXT;

        /// <summary>void glCompressedMultiTexImage2DEXT(GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, void* bits);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLint, GLsizei, void*, void> glCompressedMultiTexImage2DEXT;

        /// <summary>void glCompressedMultiTexImage3DEXT(GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, void* bits);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLsizei, GLint, GLsizei, void*, void> glCompressedMultiTexImage3DEXT;

        /// <summary>void glCompressedMultiTexSubImage1DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, void* bits);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, GLint, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedMultiTexSubImage1DEXT;

        /// <summary>void glCompressedMultiTexSubImage2DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, void* bits);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, GLint, GLint, GLsizei, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedMultiTexSubImage2DEXT;

        /// <summary>void glCompressedMultiTexSubImage3DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, void* bits);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedMultiTexSubImage3DEXT;

        /// <summary>void glCompressedTextureImage1DEXT(GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, void* bits);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, GLint, InternalFormat, GLsizei, GLint, GLsizei, void*, void> glCompressedTextureImage1DEXT;

        /// <summary>void glCompressedTextureImage2DEXT(GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, void* bits);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLint, GLsizei, void*, void> glCompressedTextureImage2DEXT;

        /// <summary>void glCompressedTextureImage3DEXT(GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, void* bits);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLsizei, GLint, GLsizei, void*, void> glCompressedTextureImage3DEXT;

        /// <summary>void glCompressedTextureSubImage1DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, void* bits);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, GLint, GLint, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedTextureSubImage1DEXT;

        /// <summary>void glCompressedTextureSubImage2DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, void* bits);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, GLint, GLint, GLint, GLsizei, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedTextureSubImage2DEXT;

        /// <summary>void glCompressedTextureSubImage3DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, void* bits);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedTextureSubImage3DEXT;

        /// <summary>void glCopyMultiTexImage1DEXT(GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLint border);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, InternalFormat, GLint, GLint, GLsizei, GLint, void> glCopyMultiTexImage1DEXT;

        /// <summary>void glCopyMultiTexImage2DEXT(GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, InternalFormat, GLint, GLint, GLsizei, GLsizei, GLint, void> glCopyMultiTexImage2DEXT;

        /// <summary>void glCopyMultiTexSubImage1DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, GLint, GLint, GLint, GLsizei, void> glCopyMultiTexSubImage1DEXT;

        /// <summary>void glCopyMultiTexSubImage2DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei, void> glCopyMultiTexSubImage2DEXT;

        /// <summary>void glCopyMultiTexSubImage3DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei, void> glCopyMultiTexSubImage3DEXT;

        /// <summary>void glCopyTextureImage1DEXT(GLuint texture, GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLint border);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, GLint, InternalFormat, GLint, GLint, GLsizei, GLint, void> glCopyTextureImage1DEXT;

        /// <summary>void glCopyTextureImage2DEXT(GLuint texture, GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, GLint, InternalFormat, GLint, GLint, GLsizei, GLsizei, GLint, void> glCopyTextureImage2DEXT;

        /// <summary>void glCopyTextureSubImage1DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, GLint, GLint, GLint, GLint, GLsizei, void> glCopyTextureSubImage1DEXT;

        /// <summary>void glCopyTextureSubImage2DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei, void> glCopyTextureSubImage2DEXT;

        /// <summary>void glCopyTextureSubImage3DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, GLint, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei, void> glCopyTextureSubImage3DEXT;

        /// <summary>void glDisableClientStateiEXT(GLenum array, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glDisableClientStateiEXT;

        /// <summary>void glDisableClientStateIndexedEXT(GLenum array, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glDisableClientStateIndexedEXT;

        /// <summary>void glDisableIndexedEXT(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glDisableIndexedEXT;

        /// <summary>void glDisableVertexArrayAttribEXT(GLuint vaobj, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLuint, void> glDisableVertexArrayAttribEXT;

        /// <summary>void glDisableVertexArrayEXT(GLuint vaobj, GLenum array);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, EnableCap, void> glDisableVertexArrayEXT;

        /// <summary>void glEnableClientStateiEXT(GLenum array, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glEnableClientStateiEXT;

        /// <summary>void glEnableClientStateIndexedEXT(GLenum array, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glEnableClientStateIndexedEXT;

        /// <summary>void glEnableIndexedEXT(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glEnableIndexedEXT;

        /// <summary>void glEnableVertexArrayAttribEXT(GLuint vaobj, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLuint, void> glEnableVertexArrayAttribEXT;

        /// <summary>void glEnableVertexArrayEXT(GLuint vaobj, GLenum array);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, EnableCap, void> glEnableVertexArrayEXT;

        /// <summary>void glFlushMappedNamedBufferRangeEXT(GLuint buffer, GLintptr offset, GLsizeiptr length);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLintptr, GLsizeiptr, void> glFlushMappedNamedBufferRangeEXT;

        /// <summary>void glFramebufferDrawBufferEXT(GLuint framebuffer, GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, DrawBufferMode, void> glFramebufferDrawBufferEXT;

        /// <summary>void glFramebufferDrawBuffersEXT(GLuint framebuffer, GLsizei n, GLenum* bufs);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, GLsizei, DrawBufferMode*, void> glFramebufferDrawBuffersEXT;

        /// <summary>void glFramebufferReadBufferEXT(GLuint framebuffer, GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, ReadBufferMode, void> glFramebufferReadBufferEXT;

        /// <summary>void glGenerateMultiTexMipmapEXT(GLenum texunit, GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, void> glGenerateMultiTexMipmapEXT;

        /// <summary>void glGenerateTextureMipmapEXT(GLuint texture, GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, void> glGenerateTextureMipmapEXT;

        /// <summary>void glGetBooleanIndexedvEXT(GLenum target, GLuint index, GLboolean* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, GLboolean*, void> glGetBooleanIndexedvEXT;

        /// <summary>void glGetCompressedMultiTexImageEXT(GLenum texunit, GLenum target, GLint lod, void* img);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, void*, void> glGetCompressedMultiTexImageEXT;

        /// <summary>void glGetCompressedTextureImageEXT(GLuint texture, GLenum target, GLint lod, void* img);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, GLint, void*, void> glGetCompressedTextureImageEXT;

        /// <summary>void glGetDoublei_vEXT(GLenum pname, GLuint index, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLdouble*, void> glGetDoublei_vEXT;

        /// <summary>void glGetDoubleIndexedvEXT(GLenum target, GLuint index, GLdouble* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLdouble*, void> glGetDoubleIndexedvEXT;

        /// <summary>void glGetFloati_vEXT(GLenum pname, GLuint index, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLfloat*, void> glGetFloati_vEXT;

        /// <summary>void glGetFloatIndexedvEXT(GLenum target, GLuint index, GLfloat* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLfloat*, void> glGetFloatIndexedvEXT;

        /// <summary>void glGetFramebufferParameterivEXT(GLuint framebuffer, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, GetFramebufferParameter, GLint*, void> glGetFramebufferParameterivEXT;

        /// <summary>void glGetIntegerIndexedvEXT(GLenum target, GLuint index, GLint* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLint*, void> glGetIntegerIndexedvEXT;

        /// <summary>void glGetMultiTexEnvfvEXT(GLenum texunit, GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureEnvTarget, TextureEnvParameter, GLfloat*, void> glGetMultiTexEnvfvEXT;

        /// <summary>void glGetMultiTexEnvivEXT(GLenum texunit, GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureEnvTarget, TextureEnvParameter, GLint*, void> glGetMultiTexEnvivEXT;

        /// <summary>void glGetMultiTexGendvEXT(GLenum texunit, GLenum coord, GLenum pname, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureCoordName, TextureGenParameter, GLdouble*, void> glGetMultiTexGendvEXT;

        /// <summary>void glGetMultiTexGenfvEXT(GLenum texunit, GLenum coord, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureCoordName, TextureGenParameter, GLfloat*, void> glGetMultiTexGenfvEXT;

        /// <summary>void glGetMultiTexGenivEXT(GLenum texunit, GLenum coord, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureCoordName, TextureGenParameter, GLint*, void> glGetMultiTexGenivEXT;

        /// <summary>void glGetMultiTexImageEXT(GLenum texunit, GLenum target, GLint level, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, PixelFormat, PixelType, void*, void> glGetMultiTexImageEXT;

        /// <summary>void glGetMultiTexLevelParameterfvEXT(GLenum texunit, GLenum target, GLint level, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, GetTextureParameter, GLfloat*, void> glGetMultiTexLevelParameterfvEXT;

        /// <summary>void glGetMultiTexLevelParameterivEXT(GLenum texunit, GLenum target, GLint level, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, GetTextureParameter, GLint*, void> glGetMultiTexLevelParameterivEXT;

        /// <summary>void glGetMultiTexParameterfvEXT(GLenum texunit, GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GetTextureParameter, GLfloat*, void> glGetMultiTexParameterfvEXT;

        /// <summary>void glGetMultiTexParameterIivEXT(GLenum texunit, GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GetTextureParameter, GLint*, void> glGetMultiTexParameterIivEXT;

        /// <summary>void glGetMultiTexParameterIuivEXT(GLenum texunit, GLenum target, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GetTextureParameter, GLuint*, void> glGetMultiTexParameterIuivEXT;

        /// <summary>void glGetMultiTexParameterivEXT(GLenum texunit, GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GetTextureParameter, GLint*, void> glGetMultiTexParameterivEXT;

        /// <summary>void glGetNamedBufferParameterivEXT(GLuint buffer, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, BufferPNameARB, GLint*, void> glGetNamedBufferParameterivEXT;

        /// <summary>void glGetNamedBufferPointervEXT(GLuint buffer, GLenum pname, void** params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, BufferPointerNameARB, void**, void> glGetNamedBufferPointervEXT;

        /// <summary>void glGetNamedBufferSubDataEXT(GLuint buffer, GLintptr offset, GLsizeiptr size, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLintptr, GLsizeiptr, void*, void> glGetNamedBufferSubDataEXT;

        /// <summary>void glGetNamedFramebufferAttachmentParameterivEXT(GLuint framebuffer, GLenum attachment, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, FramebufferAttachment, FramebufferAttachmentParameterName, GLint*, void> glGetNamedFramebufferAttachmentParameterivEXT;

        /// <summary>void glGetNamedFramebufferParameterivEXT(GLuint framebuffer, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, GetFramebufferParameter, GLint*, void> glGetNamedFramebufferParameterivEXT;

        /// <summary>void glGetNamedProgramivEXT(GLuint program, GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramTarget, ProgramPropertyARB, GLint*, void> glGetNamedProgramivEXT;

        /// <summary>void glGetNamedProgramLocalParameterdvEXT(GLuint program, GLenum target, GLuint index, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramTarget, GLuint, GLdouble*, void> glGetNamedProgramLocalParameterdvEXT;

        /// <summary>void glGetNamedProgramLocalParameterfvEXT(GLuint program, GLenum target, GLuint index, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramTarget, GLuint, GLfloat*, void> glGetNamedProgramLocalParameterfvEXT;

        /// <summary>void glGetNamedProgramLocalParameterIivEXT(GLuint program, GLenum target, GLuint index, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramTarget, GLuint, GLint*, void> glGetNamedProgramLocalParameterIivEXT;

        /// <summary>void glGetNamedProgramLocalParameterIuivEXT(GLuint program, GLenum target, GLuint index, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramTarget, GLuint, GLuint*, void> glGetNamedProgramLocalParameterIuivEXT;

        /// <summary>void glGetNamedProgramStringEXT(GLuint program, GLenum target, GLenum pname, void* string);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramTarget, ProgramStringProperty, void*, void> glGetNamedProgramStringEXT;

        /// <summary>void glGetNamedRenderbufferParameterivEXT(GLuint renderbuffer, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLrenderbuffer, RenderbufferParameterName, GLint*, void> glGetNamedRenderbufferParameterivEXT;

        /// <summary>void glGetPointeri_vEXT(GLenum pname, GLuint index, void** params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, void**, void> glGetPointeri_vEXT;

        /// <summary>void glGetPointerIndexedvEXT(GLenum target, GLuint index, void** data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, void**, void> glGetPointerIndexedvEXT;

        /// <summary>void glGetTextureImageEXT(GLuint texture, GLenum target, GLint level, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, GLint, PixelFormat, PixelType, void*, void> glGetTextureImageEXT;

        /// <summary>void glGetTextureLevelParameterfvEXT(GLuint texture, GLenum target, GLint level, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, GLint, GetTextureParameter, GLfloat*, void> glGetTextureLevelParameterfvEXT;

        /// <summary>void glGetTextureLevelParameterivEXT(GLuint texture, GLenum target, GLint level, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, GLint, GetTextureParameter, GLint*, void> glGetTextureLevelParameterivEXT;

        /// <summary>void glGetTextureParameterfvEXT(GLuint texture, GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, GetTextureParameter, GLfloat*, void> glGetTextureParameterfvEXT;

        /// <summary>void glGetTextureParameterIivEXT(GLuint texture, GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, GetTextureParameter, GLint*, void> glGetTextureParameterIivEXT;

        /// <summary>void glGetTextureParameterIuivEXT(GLuint texture, GLenum target, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, GetTextureParameter, GLuint*, void> glGetTextureParameterIuivEXT;

        /// <summary>void glGetTextureParameterivEXT(GLuint texture, GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, GetTextureParameter, GLint*, void> glGetTextureParameterivEXT;

        /// <summary>void glGetVertexArrayIntegeri_vEXT(GLuint vaobj, GLuint index, GLenum pname, GLint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLuint, VertexArrayPName, GLint*, void> glGetVertexArrayIntegeri_vEXT;

        /// <summary>void glGetVertexArrayIntegervEXT(GLuint vaobj, GLenum pname, GLint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, VertexArrayPName, GLint*, void> glGetVertexArrayIntegervEXT;

        /// <summary>void glGetVertexArrayPointeri_vEXT(GLuint vaobj, GLuint index, GLenum pname, void** param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLuint, VertexArrayPName, void**, void> glGetVertexArrayPointeri_vEXT;

        /// <summary>void glGetVertexArrayPointervEXT(GLuint vaobj, GLenum pname, void** param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, VertexArrayPName, void**, void> glGetVertexArrayPointervEXT;

        /// <summary>GLboolean glIsEnabledIndexedEXT(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, GLboolean> glIsEnabledIndexedEXT;

        /// <summary>void* glMapNamedBufferEXT(GLuint buffer, GLenum access);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, BufferAccessARB, void*> glMapNamedBufferEXT;

        /// <summary>void* glMapNamedBufferRangeEXT(GLuint buffer, GLintptr offset, GLsizeiptr length, GLbitfield access);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLintptr, GLsizeiptr, MapBufferAccessMask, void*> glMapNamedBufferRangeEXT;

        /// <summary>void glMatrixFrustumEXT(GLenum mode, GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble, GLdouble, GLdouble, GLdouble, GLdouble, GLdouble, void> glMatrixFrustumEXT;

        /// <summary>void glMatrixLoaddEXT(GLenum mode, GLdouble* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble*, void> glMatrixLoaddEXT;

        /// <summary>void glMatrixLoadfEXT(GLenum mode, GLfloat* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLfloat*, void> glMatrixLoadfEXT;

        /// <summary>void glMatrixLoadIdentityEXT(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, void> glMatrixLoadIdentityEXT;

        /// <summary>void glMatrixLoadTransposedEXT(GLenum mode, GLdouble* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble*, void> glMatrixLoadTransposedEXT;

        /// <summary>void glMatrixLoadTransposefEXT(GLenum mode, GLfloat* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLfloat*, void> glMatrixLoadTransposefEXT;

        /// <summary>void glMatrixMultdEXT(GLenum mode, GLdouble* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble*, void> glMatrixMultdEXT;

        /// <summary>void glMatrixMultfEXT(GLenum mode, GLfloat* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLfloat*, void> glMatrixMultfEXT;

        /// <summary>void glMatrixMultTransposedEXT(GLenum mode, GLdouble* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble*, void> glMatrixMultTransposedEXT;

        /// <summary>void glMatrixMultTransposefEXT(GLenum mode, GLfloat* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLfloat*, void> glMatrixMultTransposefEXT;

        /// <summary>void glMatrixOrthoEXT(GLenum mode, GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble, GLdouble, GLdouble, GLdouble, GLdouble, GLdouble, void> glMatrixOrthoEXT;

        /// <summary>void glMatrixPopEXT(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, void> glMatrixPopEXT;

        /// <summary>void glMatrixPushEXT(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, void> glMatrixPushEXT;

        /// <summary>void glMatrixRotatedEXT(GLenum mode, GLdouble angle, GLdouble x, GLdouble y, GLdouble z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble, GLdouble, GLdouble, GLdouble, void> glMatrixRotatedEXT;

        /// <summary>void glMatrixRotatefEXT(GLenum mode, GLfloat angle, GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLfloat, GLfloat, GLfloat, GLfloat, void> glMatrixRotatefEXT;

        /// <summary>void glMatrixScaledEXT(GLenum mode, GLdouble x, GLdouble y, GLdouble z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble, GLdouble, GLdouble, void> glMatrixScaledEXT;

        /// <summary>void glMatrixScalefEXT(GLenum mode, GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLfloat, GLfloat, GLfloat, void> glMatrixScalefEXT;

        /// <summary>void glMatrixTranslatedEXT(GLenum mode, GLdouble x, GLdouble y, GLdouble z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLdouble, GLdouble, GLdouble, void> glMatrixTranslatedEXT;

        /// <summary>void glMatrixTranslatefEXT(GLenum mode, GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MatrixMode, GLfloat, GLfloat, GLfloat, void> glMatrixTranslatefEXT;

        /// <summary>void glMultiTexBufferEXT(GLenum texunit, GLenum target, GLenum internalformat, GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, InternalFormat, GLbuffer, void> glMultiTexBufferEXT;

        /// <summary>void glMultiTexCoordPointerEXT(GLenum texunit, GLint size, GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLint, TexCoordPointerType, GLsizei, void*, void> glMultiTexCoordPointerEXT;

        /// <summary>void glMultiTexEnvfEXT(GLenum texunit, GLenum target, GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureEnvTarget, TextureEnvParameter, GLfloat, void> glMultiTexEnvfEXT;

        /// <summary>void glMultiTexEnvfvEXT(GLenum texunit, GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureEnvTarget, TextureEnvParameter, GLfloat*, void> glMultiTexEnvfvEXT;

        /// <summary>void glMultiTexEnviEXT(GLenum texunit, GLenum target, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureEnvTarget, TextureEnvParameter, GLint, void> glMultiTexEnviEXT;

        /// <summary>void glMultiTexEnvivEXT(GLenum texunit, GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureEnvTarget, TextureEnvParameter, GLint*, void> glMultiTexEnvivEXT;

        /// <summary>void glMultiTexGendEXT(GLenum texunit, GLenum coord, GLenum pname, GLdouble param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureCoordName, TextureGenParameter, GLdouble, void> glMultiTexGendEXT;

        /// <summary>void glMultiTexGendvEXT(GLenum texunit, GLenum coord, GLenum pname, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureCoordName, TextureGenParameter, GLdouble*, void> glMultiTexGendvEXT;

        /// <summary>void glMultiTexGenfEXT(GLenum texunit, GLenum coord, GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureCoordName, TextureGenParameter, GLfloat, void> glMultiTexGenfEXT;

        /// <summary>void glMultiTexGenfvEXT(GLenum texunit, GLenum coord, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureCoordName, TextureGenParameter, GLfloat*, void> glMultiTexGenfvEXT;

        /// <summary>void glMultiTexGeniEXT(GLenum texunit, GLenum coord, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureCoordName, TextureGenParameter, GLint, void> glMultiTexGeniEXT;

        /// <summary>void glMultiTexGenivEXT(GLenum texunit, GLenum coord, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureCoordName, TextureGenParameter, GLint*, void> glMultiTexGenivEXT;

        /// <summary>void glMultiTexImage1DEXT(GLenum texunit, GLenum target, GLint level, GLint internalformat, GLsizei width, GLint border, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, InternalFormat, GLsizei, GLint, PixelFormat, PixelType, void*, void> glMultiTexImage1DEXT;

        /// <summary>void glMultiTexImage2DEXT(GLenum texunit, GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLint, PixelFormat, PixelType, void*, void> glMultiTexImage2DEXT;

        /// <summary>void glMultiTexImage3DEXT(GLenum texunit, GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLsizei, GLint, PixelFormat, PixelType, void*, void> glMultiTexImage3DEXT;

        /// <summary>void glMultiTexParameterfEXT(GLenum texunit, GLenum target, GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, TextureParameterName, GLfloat, void> glMultiTexParameterfEXT;

        /// <summary>void glMultiTexParameterfvEXT(GLenum texunit, GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, TextureParameterName, GLfloat*, void> glMultiTexParameterfvEXT;

        /// <summary>void glMultiTexParameteriEXT(GLenum texunit, GLenum target, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, TextureParameterName, GLint, void> glMultiTexParameteriEXT;

        /// <summary>void glMultiTexParameterIivEXT(GLenum texunit, GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, TextureParameterName, GLint*, void> glMultiTexParameterIivEXT;

        /// <summary>void glMultiTexParameterIuivEXT(GLenum texunit, GLenum target, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, TextureParameterName, GLuint*, void> glMultiTexParameterIuivEXT;

        /// <summary>void glMultiTexParameterivEXT(GLenum texunit, GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, TextureParameterName, GLint*, void> glMultiTexParameterivEXT;

        /// <summary>void glMultiTexRenderbufferEXT(GLenum texunit, GLenum target, GLuint renderbuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLrenderbuffer, void> glMultiTexRenderbufferEXT;

        /// <summary>void glMultiTexSubImage1DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, GLint, GLsizei, PixelFormat, PixelType, void*, void> glMultiTexSubImage1DEXT;

        /// <summary>void glMultiTexSubImage2DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glMultiTexSubImage2DEXT;

        /// <summary>void glMultiTexSubImage3DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureTarget, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glMultiTexSubImage3DEXT;

        /// <summary>void glNamedBufferDataEXT(GLuint buffer, GLsizeiptr size, void* data, GLenum usage);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLsizeiptr, void*, VertexBufferObjectUsage, void> glNamedBufferDataEXT;

        /// <summary>void glNamedBufferStorageEXT(GLuint buffer, GLsizeiptr size, void* data, GLbitfield flags);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLsizeiptr, void*, BufferStorageMask, void> glNamedBufferStorageEXT;

        /// <summary>void glNamedBufferSubDataEXT(GLuint buffer, GLintptr offset, GLsizeiptr size, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLintptr, GLsizeiptr, void*, void> glNamedBufferSubDataEXT;

        /// <summary>void glNamedCopyBufferSubDataEXT(GLuint readBuffer, GLuint writeBuffer, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLbuffer, GLintptr, GLintptr, GLsizeiptr, void> glNamedCopyBufferSubDataEXT;

        /// <summary>void glNamedFramebufferParameteriEXT(GLuint framebuffer, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, FramebufferParameterName, GLint, void> glNamedFramebufferParameteriEXT;

        /// <summary>void glNamedFramebufferRenderbufferEXT(GLuint framebuffer, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, FramebufferAttachment, RenderbufferTarget, GLrenderbuffer, void> glNamedFramebufferRenderbufferEXT;

        /// <summary>void glNamedFramebufferTexture1DEXT(GLuint framebuffer, GLenum attachment, GLenum textarget, GLuint texture, GLint level);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, FramebufferAttachment, TextureTarget, GLtexture, GLint, void> glNamedFramebufferTexture1DEXT;

        /// <summary>void glNamedFramebufferTexture2DEXT(GLuint framebuffer, GLenum attachment, GLenum textarget, GLuint texture, GLint level);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, FramebufferAttachment, TextureTarget, GLtexture, GLint, void> glNamedFramebufferTexture2DEXT;

        /// <summary>void glNamedFramebufferTexture3DEXT(GLuint framebuffer, GLenum attachment, GLenum textarget, GLuint texture, GLint level, GLint zoffset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, FramebufferAttachment, TextureTarget, GLtexture, GLint, GLint, void> glNamedFramebufferTexture3DEXT;

        /// <summary>void glNamedFramebufferTextureEXT(GLuint framebuffer, GLenum attachment, GLuint texture, GLint level);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, FramebufferAttachment, GLtexture, GLint, void> glNamedFramebufferTextureEXT;

        /// <summary>void glNamedFramebufferTextureFaceEXT(GLuint framebuffer, GLenum attachment, GLuint texture, GLint level, GLenum face);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, FramebufferAttachment, GLtexture, GLint, TextureTarget, void> glNamedFramebufferTextureFaceEXT;

        /// <summary>void glNamedFramebufferTextureLayerEXT(GLuint framebuffer, GLenum attachment, GLuint texture, GLint level, GLint layer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, FramebufferAttachment, GLtexture, GLint, GLint, void> glNamedFramebufferTextureLayerEXT;

        /// <summary>void glNamedProgramLocalParameter4dEXT(GLuint program, GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramTarget, GLuint, GLdouble, GLdouble, GLdouble, GLdouble, void> glNamedProgramLocalParameter4dEXT;

        /// <summary>void glNamedProgramLocalParameter4dvEXT(GLuint program, GLenum target, GLuint index, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramTarget, GLuint, GLdouble*, void> glNamedProgramLocalParameter4dvEXT;

        /// <summary>void glNamedProgramLocalParameter4fEXT(GLuint program, GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramTarget, GLuint, GLfloat, GLfloat, GLfloat, GLfloat, void> glNamedProgramLocalParameter4fEXT;

        /// <summary>void glNamedProgramLocalParameter4fvEXT(GLuint program, GLenum target, GLuint index, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramTarget, GLuint, GLfloat*, void> glNamedProgramLocalParameter4fvEXT;

        /// <summary>void glNamedProgramLocalParameterI4iEXT(GLuint program, GLenum target, GLuint index, GLint x, GLint y, GLint z, GLint w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramTarget, GLuint, GLint, GLint, GLint, GLint, void> glNamedProgramLocalParameterI4iEXT;

        /// <summary>void glNamedProgramLocalParameterI4ivEXT(GLuint program, GLenum target, GLuint index, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramTarget, GLuint, GLint*, void> glNamedProgramLocalParameterI4ivEXT;

        /// <summary>void glNamedProgramLocalParameterI4uiEXT(GLuint program, GLenum target, GLuint index, GLuint x, GLuint y, GLuint z, GLuint w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramTarget, GLuint, GLuint, GLuint, GLuint, GLuint, void> glNamedProgramLocalParameterI4uiEXT;

        /// <summary>void glNamedProgramLocalParameterI4uivEXT(GLuint program, GLenum target, GLuint index, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramTarget, GLuint, GLuint*, void> glNamedProgramLocalParameterI4uivEXT;

        /// <summary>void glNamedProgramLocalParameters4fvEXT(GLuint program, GLenum target, GLuint index, GLsizei count, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramTarget, GLuint, GLsizei, GLfloat*, void> glNamedProgramLocalParameters4fvEXT;

        /// <summary>void glNamedProgramLocalParametersI4ivEXT(GLuint program, GLenum target, GLuint index, GLsizei count, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramTarget, GLuint, GLsizei, GLint*, void> glNamedProgramLocalParametersI4ivEXT;

        /// <summary>void glNamedProgramLocalParametersI4uivEXT(GLuint program, GLenum target, GLuint index, GLsizei count, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramTarget, GLuint, GLsizei, GLuint*, void> glNamedProgramLocalParametersI4uivEXT;

        /// <summary>void glNamedProgramStringEXT(GLuint program, GLenum target, GLenum format, GLsizei len, void* string);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramTarget, ProgramFormat, GLsizei, void*, void> glNamedProgramStringEXT;

        /// <summary>void glNamedRenderbufferStorageEXT(GLuint renderbuffer, GLenum internalformat, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLrenderbuffer, InternalFormat, GLsizei, GLsizei, void> glNamedRenderbufferStorageEXT;

        /// <summary>void glNamedRenderbufferStorageMultisampleCoverageEXT(GLuint renderbuffer, GLsizei coverageSamples, GLsizei colorSamples, GLenum internalformat, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLrenderbuffer, GLsizei, GLsizei, InternalFormat, GLsizei, GLsizei, void> glNamedRenderbufferStorageMultisampleCoverageEXT;

        /// <summary>void glNamedRenderbufferStorageMultisampleEXT(GLuint renderbuffer, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLrenderbuffer, GLsizei, InternalFormat, GLsizei, GLsizei, void> glNamedRenderbufferStorageMultisampleEXT;

        /// <summary>void glProgramUniform1dEXT(GLuint program, GLint location, GLdouble x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLdouble, void> glProgramUniform1dEXT;

        /// <summary>void glProgramUniform1dvEXT(GLuint program, GLint location, GLsizei count, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLdouble*, void> glProgramUniform1dvEXT;

        /// <summary>void glProgramUniform1fEXT(GLuint program, GLint location, GLfloat v0);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLfloat, void> glProgramUniform1fEXT;

        /// <summary>void glProgramUniform1fvEXT(GLuint program, GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLfloat*, void> glProgramUniform1fvEXT;

        /// <summary>void glProgramUniform1iEXT(GLuint program, GLint location, GLint v0);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLint, void> glProgramUniform1iEXT;

        /// <summary>void glProgramUniform1ivEXT(GLuint program, GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint*, void> glProgramUniform1ivEXT;

        /// <summary>void glProgramUniform1uiEXT(GLuint program, GLint location, GLuint v0);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint, void> glProgramUniform1uiEXT;

        /// <summary>void glProgramUniform1uivEXT(GLuint program, GLint location, GLsizei count, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint*, void> glProgramUniform1uivEXT;

        /// <summary>void glProgramUniform2dEXT(GLuint program, GLint location, GLdouble x, GLdouble y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLdouble, GLdouble, void> glProgramUniform2dEXT;

        /// <summary>void glProgramUniform2dvEXT(GLuint program, GLint location, GLsizei count, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLdouble*, void> glProgramUniform2dvEXT;

        /// <summary>void glProgramUniform2fEXT(GLuint program, GLint location, GLfloat v0, GLfloat v1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLfloat, GLfloat, void> glProgramUniform2fEXT;

        /// <summary>void glProgramUniform2fvEXT(GLuint program, GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLfloat*, void> glProgramUniform2fvEXT;

        /// <summary>void glProgramUniform2iEXT(GLuint program, GLint location, GLint v0, GLint v1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLint, GLint, void> glProgramUniform2iEXT;

        /// <summary>void glProgramUniform2ivEXT(GLuint program, GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint*, void> glProgramUniform2ivEXT;

        /// <summary>void glProgramUniform2uiEXT(GLuint program, GLint location, GLuint v0, GLuint v1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint, GLuint, void> glProgramUniform2uiEXT;

        /// <summary>void glProgramUniform2uivEXT(GLuint program, GLint location, GLsizei count, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint*, void> glProgramUniform2uivEXT;

        /// <summary>void glProgramUniform3dEXT(GLuint program, GLint location, GLdouble x, GLdouble y, GLdouble z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLdouble, GLdouble, GLdouble, void> glProgramUniform3dEXT;

        /// <summary>void glProgramUniform3dvEXT(GLuint program, GLint location, GLsizei count, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLdouble*, void> glProgramUniform3dvEXT;

        /// <summary>void glProgramUniform3fEXT(GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLfloat, GLfloat, GLfloat, void> glProgramUniform3fEXT;

        /// <summary>void glProgramUniform3fvEXT(GLuint program, GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLfloat*, void> glProgramUniform3fvEXT;

        /// <summary>void glProgramUniform3iEXT(GLuint program, GLint location, GLint v0, GLint v1, GLint v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLint, GLint, GLint, void> glProgramUniform3iEXT;

        /// <summary>void glProgramUniform3ivEXT(GLuint program, GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint*, void> glProgramUniform3ivEXT;

        /// <summary>void glProgramUniform3uiEXT(GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint, GLuint, GLuint, void> glProgramUniform3uiEXT;

        /// <summary>void glProgramUniform3uivEXT(GLuint program, GLint location, GLsizei count, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint*, void> glProgramUniform3uivEXT;

        /// <summary>void glProgramUniform4dEXT(GLuint program, GLint location, GLdouble x, GLdouble y, GLdouble z, GLdouble w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLdouble, GLdouble, GLdouble, GLdouble, void> glProgramUniform4dEXT;

        /// <summary>void glProgramUniform4dvEXT(GLuint program, GLint location, GLsizei count, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLdouble*, void> glProgramUniform4dvEXT;

        /// <summary>void glProgramUniform4fEXT(GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLfloat, GLfloat, GLfloat, GLfloat, void> glProgramUniform4fEXT;

        /// <summary>void glProgramUniform4fvEXT(GLuint program, GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLfloat*, void> glProgramUniform4fvEXT;

        /// <summary>void glProgramUniform4iEXT(GLuint program, GLint location, GLint v0, GLint v1, GLint v2, GLint v3);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLint, GLint, GLint, GLint, void> glProgramUniform4iEXT;

        /// <summary>void glProgramUniform4ivEXT(GLuint program, GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint*, void> glProgramUniform4ivEXT;

        /// <summary>void glProgramUniform4uiEXT(GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint, GLuint, GLuint, GLuint, void> glProgramUniform4uiEXT;

        /// <summary>void glProgramUniform4uivEXT(GLuint program, GLint location, GLsizei count, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint*, void> glProgramUniform4uivEXT;

        /// <summary>void glProgramUniformMatrix2dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix2dvEXT;

        /// <summary>void glProgramUniformMatrix2fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix2fvEXT;

        /// <summary>void glProgramUniformMatrix2x3dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix2x3dvEXT;

        /// <summary>void glProgramUniformMatrix2x3fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix2x3fvEXT;

        /// <summary>void glProgramUniformMatrix2x4dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix2x4dvEXT;

        /// <summary>void glProgramUniformMatrix2x4fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix2x4fvEXT;

        /// <summary>void glProgramUniformMatrix3dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix3dvEXT;

        /// <summary>void glProgramUniformMatrix3fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix3fvEXT;

        /// <summary>void glProgramUniformMatrix3x2dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix3x2dvEXT;

        /// <summary>void glProgramUniformMatrix3x2fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix3x2fvEXT;

        /// <summary>void glProgramUniformMatrix3x4dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix3x4dvEXT;

        /// <summary>void glProgramUniformMatrix3x4fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix3x4fvEXT;

        /// <summary>void glProgramUniformMatrix4dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix4dvEXT;

        /// <summary>void glProgramUniformMatrix4fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix4fvEXT;

        /// <summary>void glProgramUniformMatrix4x2dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix4x2dvEXT;

        /// <summary>void glProgramUniformMatrix4x2fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix4x2fvEXT;

        /// <summary>void glProgramUniformMatrix4x3dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix4x3dvEXT;

        /// <summary>void glProgramUniformMatrix4x3fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix4x3fvEXT;

        /// <summary>void glPushClientAttribDefaultEXT(GLbitfield mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClientAttribMask, void> glPushClientAttribDefaultEXT;

        /// <summary>void glTextureBufferEXT(GLuint texture, GLenum target, GLenum internalformat, GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, SizedInternalFormat, GLbuffer, void> glTextureBufferEXT;

        /// <summary>void glTextureBufferRangeEXT(GLuint texture, GLenum target, GLenum internalformat, GLuint buffer, GLintptr offset, GLsizeiptr size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, SizedInternalFormat, GLbuffer, GLintptr, GLsizeiptr, void> glTextureBufferRangeEXT;

        /// <summary>void glTextureImage1DEXT(GLuint texture, GLenum target, GLint level, GLint internalformat, GLsizei width, GLint border, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, GLint, InternalFormat, GLsizei, GLint, PixelFormat, PixelType, void*, void> glTextureImage1DEXT;

        /// <summary>void glTextureImage2DEXT(GLuint texture, GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLint, PixelFormat, PixelType, void*, void> glTextureImage2DEXT;

        /// <summary>void glTextureImage3DEXT(GLuint texture, GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLsizei, GLint, PixelFormat, PixelType, void*, void> glTextureImage3DEXT;

        /// <summary>void glTexturePageCommitmentEXT(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLboolean commit);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, GLboolean, void> glTexturePageCommitmentEXT;

        /// <summary>void glTextureParameterfEXT(GLuint texture, GLenum target, GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, TextureParameterName, GLfloat, void> glTextureParameterfEXT;

        /// <summary>void glTextureParameterfvEXT(GLuint texture, GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, TextureParameterName, GLfloat*, void> glTextureParameterfvEXT;

        /// <summary>void glTextureParameteriEXT(GLuint texture, GLenum target, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, TextureParameterName, GLint, void> glTextureParameteriEXT;

        /// <summary>void glTextureParameterIivEXT(GLuint texture, GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, TextureParameterName, GLint*, void> glTextureParameterIivEXT;

        /// <summary>void glTextureParameterIuivEXT(GLuint texture, GLenum target, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, TextureParameterName, GLuint*, void> glTextureParameterIuivEXT;

        /// <summary>void glTextureParameterivEXT(GLuint texture, GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, TextureParameterName, GLint*, void> glTextureParameterivEXT;

        /// <summary>void glTextureRenderbufferEXT(GLuint texture, GLenum target, GLuint renderbuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, GLrenderbuffer, void> glTextureRenderbufferEXT;

        /// <summary>void glTextureStorage1DEXT(GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLenum, GLsizei, SizedInternalFormat, GLsizei, void> glTextureStorage1DEXT;

        /// <summary>void glTextureStorage2DEXT(GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLenum, GLsizei, SizedInternalFormat, GLsizei, GLsizei, void> glTextureStorage2DEXT;

        /// <summary>void glTextureStorage2DMultisampleEXT(GLuint texture, GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLboolean, void> glTextureStorage2DMultisampleEXT;

        /// <summary>void glTextureStorage3DEXT(GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLenum, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLsizei, void> glTextureStorage3DEXT;

        /// <summary>void glTextureStorage3DMultisampleEXT(GLuint texture, GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLenum, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLsizei, GLboolean, void> glTextureStorage3DMultisampleEXT;

        /// <summary>void glTextureSubImage1DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, GLint, GLint, GLsizei, PixelFormat, PixelType, void*, void> glTextureSubImage1DEXT;

        /// <summary>void glTextureSubImage2DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, GLint, GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glTextureSubImage2DEXT;

        /// <summary>void glTextureSubImage3DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glTextureSubImage3DEXT;

        /// <summary>GLboolean glUnmapNamedBufferEXT(GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLboolean> glUnmapNamedBufferEXT;

        /// <summary>void glVertexArrayBindVertexBufferEXT(GLuint vaobj, GLuint bindingindex, GLuint buffer, GLintptr offset, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLuint, GLbuffer, GLintptr, GLsizei, void> glVertexArrayBindVertexBufferEXT;

        /// <summary>void glVertexArrayColorOffsetEXT(GLuint vaobj, GLuint buffer, GLint size, GLenum type, GLsizei stride, GLintptr offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLbuffer, GLint, ColorPointerType, GLsizei, GLintptr, void> glVertexArrayColorOffsetEXT;

        /// <summary>void glVertexArrayEdgeFlagOffsetEXT(GLuint vaobj, GLuint buffer, GLsizei stride, GLintptr offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLbuffer, GLsizei, GLintptr, void> glVertexArrayEdgeFlagOffsetEXT;

        /// <summary>void glVertexArrayFogCoordOffsetEXT(GLuint vaobj, GLuint buffer, GLenum type, GLsizei stride, GLintptr offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLbuffer, FogCoordinatePointerType, GLsizei, GLintptr, void> glVertexArrayFogCoordOffsetEXT;

        /// <summary>void glVertexArrayIndexOffsetEXT(GLuint vaobj, GLuint buffer, GLenum type, GLsizei stride, GLintptr offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLbuffer, IndexPointerType, GLsizei, GLintptr, void> glVertexArrayIndexOffsetEXT;

        /// <summary>void glVertexArrayMultiTexCoordOffsetEXT(GLuint vaobj, GLuint buffer, GLenum texunit, GLint size, GLenum type, GLsizei stride, GLintptr offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLbuffer, GLenum, GLint, TexCoordPointerType, GLsizei, GLintptr, void> glVertexArrayMultiTexCoordOffsetEXT;

        /// <summary>void glVertexArrayNormalOffsetEXT(GLuint vaobj, GLuint buffer, GLenum type, GLsizei stride, GLintptr offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLbuffer, NormalPointerType, GLsizei, GLintptr, void> glVertexArrayNormalOffsetEXT;

        /// <summary>void glVertexArraySecondaryColorOffsetEXT(GLuint vaobj, GLuint buffer, GLint size, GLenum type, GLsizei stride, GLintptr offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLbuffer, GLint, ColorPointerType, GLsizei, GLintptr, void> glVertexArraySecondaryColorOffsetEXT;

        /// <summary>void glVertexArrayTexCoordOffsetEXT(GLuint vaobj, GLuint buffer, GLint size, GLenum type, GLsizei stride, GLintptr offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLbuffer, GLint, TexCoordPointerType, GLsizei, GLintptr, void> glVertexArrayTexCoordOffsetEXT;

        /// <summary>void glVertexArrayVertexAttribBindingEXT(GLuint vaobj, GLuint attribindex, GLuint bindingindex);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLuint, GLuint, void> glVertexArrayVertexAttribBindingEXT;

        /// <summary>void glVertexArrayVertexAttribDivisorEXT(GLuint vaobj, GLuint index, GLuint divisor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLuint, GLuint, void> glVertexArrayVertexAttribDivisorEXT;

        /// <summary>void glVertexArrayVertexAttribFormatEXT(GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLboolean normalized, GLuint relativeoffset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLuint, GLint, VertexAttribType, GLboolean, GLuint, void> glVertexArrayVertexAttribFormatEXT;

        /// <summary>void glVertexArrayVertexAttribIFormatEXT(GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLuint, GLint, VertexAttribIType, GLuint, void> glVertexArrayVertexAttribIFormatEXT;

        /// <summary>void glVertexArrayVertexAttribIOffsetEXT(GLuint vaobj, GLuint buffer, GLuint index, GLint size, GLenum type, GLsizei stride, GLintptr offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLbuffer, GLuint, GLint, VertexAttribType, GLsizei, GLintptr, void> glVertexArrayVertexAttribIOffsetEXT;

        /// <summary>void glVertexArrayVertexAttribLFormatEXT(GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLuint, GLint, VertexAttribLType, GLuint, void> glVertexArrayVertexAttribLFormatEXT;

        /// <summary>void glVertexArrayVertexAttribLOffsetEXT(GLuint vaobj, GLuint buffer, GLuint index, GLint size, GLenum type, GLsizei stride, GLintptr offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLbuffer, GLuint, GLint, VertexAttribLType, GLsizei, GLintptr, void> glVertexArrayVertexAttribLOffsetEXT;

        /// <summary>void glVertexArrayVertexAttribOffsetEXT(GLuint vaobj, GLuint buffer, GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride, GLintptr offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLbuffer, GLuint, GLint, VertexAttribPointerType, GLboolean, GLsizei, GLintptr, void> glVertexArrayVertexAttribOffsetEXT;

        /// <summary>void glVertexArrayVertexBindingDivisorEXT(GLuint vaobj, GLuint bindingindex, GLuint divisor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLuint, GLuint, void> glVertexArrayVertexBindingDivisorEXT;

        /// <summary>void glVertexArrayVertexOffsetEXT(GLuint vaobj, GLuint buffer, GLint size, GLenum type, GLsizei stride, GLintptr offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLbuffer, GLint, VertexPointerType, GLsizei, GLintptr, void> glVertexArrayVertexOffsetEXT;
    }
}
#endif