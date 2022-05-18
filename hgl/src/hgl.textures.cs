namespace HGL;

partial class hgl {

    public static void ActiveTexture(TextureUnit textureUnit) {
        unsafe { gl.Functions.glActiveTexture(textureUnit); }
    }

    public static void BindImageTexture(int unit, GLtexture texture, int level, bool layered, int layer, BufferAccess access, InternalFormat format) {
        unsafe { gl.Functions.glBindImageTexture((GLuint)unit, texture, level, (GLboolean)(layered ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), layer, access, format); }
    }

    public static void BindImageTextures(int first, params GLtexture[] textures) {
        unsafe { fixed (GLtexture* pTextures = textures) gl.Functions.glBindImageTextures((GLuint)first, textures.Length, pTextures); }
    }

    public static void BindTexture(TextureTarget target, GLtexture texture) {
        unsafe { gl.Functions.glBindTexture(target, texture); }
    }

    public static void BindTextureUnit(int unit, GLtexture texture) {
        unsafe { gl.Functions.glBindTextureUnit((GLuint)unit, texture); }
    }

    public static void BindTextures(int first, params GLtexture[] textures) {
        unsafe { fixed (GLtexture* pTextures = textures) gl.Functions.glBindTextures((GLuint)first, textures.Length, pTextures); }
    }

    public static void ClearTexImage<T>(this GLtexture texture, int level, PixelFormat format, PixelType type, T[] data) where T : unmanaged {
        unsafe { fixed (T* pData = data) gl.Functions.glClearTexImage(texture, level, format, type, pData); }
    }

    public static void ClearTexSubImage<T>(this GLtexture texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, T[] data) where T : unmanaged {
        unsafe { fixed (T* pData = data) gl.Functions.glClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pData); }
    }

    public static void CompressedTexImage1D<T>(TextureTarget target, int level, InternalFormat internalformat, int width, int imageSize, T[] data) where T : unmanaged {
        unsafe { fixed (void* ptr = data) gl.Functions.glCompressedTexImage1D(target, level, internalformat, width, 0, imageSize, ptr); }
    }

    public static void CompressedTexImage2D<T>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int imageSize, T[] data) where T : unmanaged {
        unsafe { fixed (void* ptr = data) gl.Functions.glCompressedTexImage2D(target, level, internalformat, width, height, 0, imageSize, ptr); }
    }

    public static void CompressedTexImage3D<T>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int imageSize, T[] data) where T : unmanaged {
        unsafe { fixed (void* ptr = data) gl.Functions.glCompressedTexImage3D(target, level, internalformat, width, height, depth, 0, imageSize, ptr); }
    }

    public static void CompressedTexSubImage1D<T>(TextureTarget target, int level, int xoffset, int width, InternalFormat format, int imageSize, T[] data) where T : unmanaged {
        unsafe { fixed (void* ptr = data) gl.Functions.glCompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, ptr); }
    }

    public static void CompressedTextureSubImage1D<T>(this GLtexture texture, int level, int xoffset, int width, InternalFormat format, int imageSize, T[] data) where T : unmanaged {
        unsafe { fixed (void* ptr = data) gl.Functions.glCompressedTextureSubImage1D(texture, level, xoffset, width, format, imageSize, ptr); }
    }

    public static void CompressedTexSubImage2D<T>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, InternalFormat format, int imageSize, T[] data) where T : unmanaged {
        unsafe { fixed (void* ptr = data) gl.Functions.glCompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, ptr); }
    }

    public static void CompressedTextureSubImage2D<T>(this GLtexture texture, int level, int xoffset, int yoffset, int width, int height, InternalFormat format, int imageSize, T[] data) where T : unmanaged {
        unsafe { fixed (void* ptr = data) gl.Functions.glCompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, imageSize, ptr); }
    }

    public static void CompressedTexSubImage3D<T>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, int imageSize, T[] data) where T : unmanaged {
        unsafe { fixed (void* ptr = data) gl.Functions.glCompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, ptr); }
    }

    public static void CompressedTextureSubImage3D<T>(this GLtexture texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, int imageSize, T[] data) where T : unmanaged {
        unsafe { fixed (void* ptr = data) gl.Functions.glCompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, ptr); }
    }

    public static void CopyImageSubData(GLtexture srcTexture, ImageSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ,
                                        GLtexture dstTexture, ImageSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ,
                                        int width, int height, int depth) {
        unsafe { gl.Functions.glCopyImageSubData(srcTexture, srcTarget, srcLevel, srcX, srcY, srcZ, dstTexture, dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth); }
    }

    public static void CopyImageSubData(GLtexture srcTexture, ImageSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ,
                                        GLrenderbuffer dstTexture, ImageSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ,
                                        int width, int height, int depth) {
        unsafe { gl.Functions.glCopyImageSubData(srcTexture, srcTarget, srcLevel, srcX, srcY, srcZ, dstTexture, dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth); }
    }

    public static void CopyImageSubData(GLrenderbuffer srcTexture, ImageSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ,
                                        GLtexture dstTexture, ImageSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ,
                                        int width, int height, int depth) {
        unsafe { gl.Functions.glCopyImageSubData(srcTexture, srcTarget, srcLevel, srcX, srcY, srcZ, dstTexture, dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth); }
    }

    public static void CopyImageSubData(GLrenderbuffer srcTexture, ImageSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ,
                                        GLrenderbuffer dstTexture, ImageSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ,
                                        int width, int height, int depth) {
        unsafe { gl.Functions.glCopyImageSubData(srcTexture, srcTarget, srcLevel, srcX, srcY, srcZ, dstTexture, dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth); }
    }

    public static void CopyTexImage1D(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width) {
        unsafe { gl.Functions.glCopyTexImage1D(target, level, internalformat, x, y, width, 0); }
    }

    public static void CopyTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int height) {
        unsafe { gl.Functions.glCopyTexImage2D(target, level, internalformat, x, y, width, height, 0); }
    }

    public static void CopyTexSubImage1D(TextureTarget target, int level, int xoffset, int x, int y, int width) {
        unsafe { gl.Functions.glCopyTexSubImage1D(target, level, xoffset, x, y, width); }
    }

    public static void CopyTextureSubImage1D(this GLtexture texture, int level, int xoffset, int x, int y, int width) {
        unsafe { gl.Functions.glCopyTextureSubImage1D(texture, level, xoffset, x, y, width); }
    }

    public static void CopyTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height) {
        unsafe { gl.Functions.glCopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height); }
    }

    public static void CopyTextureSubImage2D(this GLtexture texture, int level, int xoffset, int yoffset, int x, int y, int width, int height) {
        unsafe { gl.Functions.glCopyTextureSubImage2D(texture, level, xoffset, yoffset, x, y, width, height); }
    }

    public static void CopyTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) {
        unsafe { gl.Functions.glCopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height); }
    }

    public static void CopyTextureSubImage3D(this GLtexture texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) {
        unsafe { gl.Functions.glCopyTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, x, y, width, height); }
    }

    public static void CreateTexture(TextureTarget target, GLtexture[] textures) {
        unsafe { fixed (GLtexture* ptr = textures) gl.Functions.glCreateTextures(target, textures.Length, ptr); }
    }

    public static void CreateTexture(TextureTarget target, out GLtexture texture) {
        unsafe { fixed (GLtexture* ptr = &texture) gl.Functions.glCreateTextures(target, 1, ptr); }
    }

    public static void DeleteTextures(params GLtexture[] textures) {
        unsafe { fixed (GLtexture* ptr = textures) gl.Functions.glDeleteTextures(textures.Length, ptr); }
    }

    public static void GenTextures(GLtexture[] textures) {
        unsafe { fixed (GLtexture* ptr = textures) gl.Functions.glGenTextures(textures.Length, ptr); }
    }

    public static void GenTextures(out GLtexture texture) {
        unsafe { fixed (GLtexture* ptr = &texture) gl.Functions.glGenTextures(1, ptr); }
    }

    public static void GetCompressedTexImage<T>(TextureTarget target, int level, T[] img) where T : unmanaged {
        unsafe { fixed (void* ptr = img) gl.Functions.glGetCompressedTexImage(target, level, ptr); }
    }

    public static void GetCompressedTexImage<T>(TextureTarget target, int level, int bufSize, T[] img) where T : unmanaged {
        unsafe { fixed (void* ptr = img) gl.Functions.glGetnCompressedTexImage(target, level, bufSize, ptr); }
    }

    public static void GetCompressedTextureImage<T>(GLtexture texure, int level, int bufSize, T[] img) where T : unmanaged {
        unsafe { fixed (void* ptr = img) gl.Functions.glGetCompressedTextureImage(texure, level, bufSize, ptr); }
    }

    public static void GetCompressedTextureSubImage<T>(GLtexture texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, T[] img) where T : unmanaged {
        unsafe { fixed (void* ptr = img) gl.Functions.glGetCompressedTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, img.Length, ptr); }
    }

    public static void GetTexImage<T>(TextureTarget target, int level, PixelFormat format, PixelType type, T[] pixels) where T : unmanaged {
        unsafe { fixed (void* ptr = pixels) gl.Functions.glGetTexImage(target, level, format, type, ptr); }
    }

    public static void GetTexImage<T>(TextureTarget target, int level, PixelFormat format, PixelType type, int bufSize, T[] pixels) where T : unmanaged {
        unsafe { fixed (void* ptr = pixels) gl.Functions.glGetnTexImage(target, level, format, type, bufSize, ptr); }
    }

    public static void GetTextureImage<T>(this GLtexture texture, int level, PixelFormat format, PixelType type, int bufSize, T[] pixels) where T : unmanaged {
        unsafe { fixed (void* ptr = pixels) gl.Functions.glGetTextureImage(texture, level, format, type, bufSize, ptr); }
    }

    public static void GetTexLevelParameter(TextureTarget target, int level, TextureParameter pname, out float parameter) {
        unsafe { fixed (GLfloat* ptr = &parameter) gl.Functions.glGetTexLevelParameterfv(target, level, pname, ptr); }
    }

    public static void GetTexLevelParameter(TextureTarget target, int level, TextureParameter pname, out int parameter) {
        unsafe { fixed (GLint* ptr = &parameter) gl.Functions.glGetTexLevelParameteriv(target, level, pname, ptr); }
    }

    public static void GetTextureLevelParameter(this GLtexture texture, int level, TextureParameter pname, out float parameter) {
        unsafe { fixed (GLfloat* ptr = &parameter) gl.Functions.glGetTextureLevelParameterfv(texture, level, pname, ptr); }
    }

    public static void GetTextureLevelParameter(this GLtexture texture, int level, TextureParameter pname, out int parameter) {
        unsafe { fixed (GLint* ptr = &parameter) gl.Functions.glGetTextureLevelParameteriv(texture, level, pname, ptr); }
    }

    public static void GetTexParameter(TextureTarget target, TextureParameter pname, float[] parameters) {
        unsafe { fixed (GLfloat* ptr = parameters) gl.Functions.glGetTexParameterfv(target, pname, ptr); }
    }

    public static void GetTexParameter(TextureTarget target, TextureParameter pname, out float parameter) {
        unsafe { fixed (GLfloat* ptr = &parameter) gl.Functions.glGetTexParameterfv(target, pname, ptr); }
    }

    public static void GetTexParameter(TextureTarget target, TextureParameter pname, int[] parameters) {
        unsafe { fixed (GLint* ptr = parameters) gl.Functions.glGetTexParameteriv(target, pname, ptr); }
    }

    public static void GetTexParameter(TextureTarget target, TextureParameter pname, out int parameter) {
        unsafe { fixed (GLint* ptr = &parameter) gl.Functions.glGetTexParameteriv(target, pname, ptr); }
    }

    public static void GetTexParameterI(TextureTarget target, TextureParameter pname, int[] parameters) {
        unsafe { fixed (GLint* ptr = parameters) gl.Functions.glGetTexParameterIiv(target, pname, ptr); }
    }

    public static void GetTexParameterI(TextureTarget target, TextureParameter pname, out int parameter) {
        unsafe { fixed (GLint* ptr = &parameter) gl.Functions.glGetTexParameterIiv(target, pname, ptr); }
    }

    public static void GetTexParameterI(TextureTarget target, TextureParameter pname, uint[] parameters) {
        unsafe { fixed (GLuint* ptr = parameters) gl.Functions.glGetTexParameterIuiv(target, pname, ptr); }
    }

    public static void GetTexParameterI(TextureTarget target, TextureParameter pname, out uint parameter) {
        unsafe { fixed (GLuint* ptr = &parameter) gl.Functions.glGetTexParameterIuiv(target, pname, ptr); }
    }

    public static void GetTextureParameter(this GLtexture texture, TextureParameter pname, float[] parameters) {
        unsafe { fixed (GLfloat* ptr = parameters) gl.Functions.glGetTextureParameterfv(texture, pname, ptr); }
    }

    public static void GetTextureParameter(this GLtexture texture, TextureParameter pname, out float parameter) {
        unsafe { fixed (GLfloat* ptr = &parameter) gl.Functions.glGetTextureParameterfv(texture, pname, ptr); }
    }

    public static void GetTextureParameter(this GLtexture texture, TextureParameter pname, int[] parameters) {
        unsafe { fixed (GLint* ptr = parameters) gl.Functions.glGetTextureParameteriv(texture, pname, ptr); }
    }

    public static void GetTextureParameter(this GLtexture texture, TextureParameter pname, out int parameter) {
        unsafe { fixed (GLint* ptr = &parameter) gl.Functions.glGetTextureParameteriv(texture, pname, ptr); }
    }

    public static void GetTextureParameterI(this GLtexture texture, TextureParameter pname, int[] parameters) {
        unsafe { fixed (GLint* ptr = parameters) gl.Functions.glGetTextureParameterIiv(texture, pname, ptr); }
    }

    public static void GetTextureParameterI(this GLtexture texture, TextureParameter pname, out int parameter) {
        unsafe { fixed (GLint* ptr = &parameter) gl.Functions.glGetTextureParameterIiv(texture, pname, ptr); }
    }

    public static void GetTextureParameterI(this GLtexture texture, TextureParameter pname, uint[] parameters) {
        unsafe { fixed (GLuint* ptr = parameters) gl.Functions.glGetTextureParameterIuiv(texture, pname, ptr); }
    }

    public static void GetTextureParameterI(this GLtexture texture, TextureParameter pname, out uint parameter) {
        unsafe { fixed (GLuint* ptr = &parameter) gl.Functions.glGetTextureParameterIuiv(texture, pname, ptr); }
    }

    public static void GetTextureSubImage<T>(this GLtexture texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, T[] img) where T : unmanaged {
        unsafe { fixed (void* ptr = img) gl.Functions.glGetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, img.Length, ptr); }
    }

    public static void InvalidateTexImage(this GLtexture texture, int level) {
        unsafe { gl.Functions.glInvalidateTexImage(texture, level); }
    }

    public static void InvalidateTexSubImage(this GLtexture texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth) {
        unsafe { gl.Functions.glInvalidateTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth); }
    }

    public static GLboolean IsTexture(this GLtexture texture) {
        unsafe { return gl.Functions.glIsTexture(texture); }
    }

    public static void TexBuffer(TextureTarget target, SizedInternalFormat internalformat, GLbuffer buffer) {
        unsafe { gl.Functions.glTexBuffer(target, internalformat, buffer); }
    }

    public static void TextureBuffer(this GLtexture texture, SizedInternalFormat internalformat, GLbuffer buffer) {
        unsafe { gl.Functions.glTextureBuffer(texture, internalformat, buffer); }
    }

    public static void TexBufferRange(TextureTarget target, SizedInternalFormat internalFormat, GLbuffer buffer, int offset, int size) {
        unsafe { gl.Functions.glTexBufferRange(target, internalFormat, buffer, (GLintptr)offset, (GLsizeiptr)size); }
    }

    public static void TextureBufferRange(GLtexture texture, SizedInternalFormat internalFormat, GLbuffer buffer, int offset, int size) {
        unsafe { gl.Functions.glTextureBufferRange(texture, internalFormat, buffer, (GLintptr)offset, (GLsizeiptr)size); }
    }

    public static void TexImage1D<T>(TextureTarget target, int level, InternalFormat internalformat, int width, PixelFormat format, PixelType type, T[] pixels) where T : unmanaged {
        unsafe { fixed (void* ptr = pixels) gl.Functions.glTexImage1D(target, level, internalformat, width, 0, format, type, ptr); }
    }

    public static void TexImage2D<T>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, T[] pixels) where T : unmanaged {
        unsafe { fixed (void* ptr = pixels) gl.Functions.glTexImage2D(target, level, internalformat, width, height, 0, format, type, ptr); }
    }

    public static void TexImage2DMultisample(TextureTarget target, int samples, InternalFormat internalformat, int width, int height, bool fixedsamplelocations) {
        unsafe { gl.Functions.glTexImage2DMultisample(target, samples, internalformat, width, height, (GLboolean)(fixedsamplelocations ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE)); }
    }

    public static void TexImage3D<T>(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, PixelFormat format, PixelType type, T[] pixels) where T : unmanaged {
        unsafe { fixed (void* ptr = pixels) gl.Functions.glTexImage3D(target, level, internalformat, width, height, depth, 0, format, type, ptr); }
    }

    public static void TexImage3DMultisample(TextureTarget target, int samples, InternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations) {
        unsafe { gl.Functions.glTexImage3DMultisample(target, samples, internalformat, width, height, depth, (GLboolean)(fixedsamplelocations ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE)); }
    }

    public static void TexParameterf(TextureTarget target, TextureParameter pname, float param) {
        unsafe { gl.Functions.glTexParameterf(target, pname, param); }
    }

    public static void TexParameteri(TextureTarget target, TextureParameter pname, int param) {
        unsafe { gl.Functions.glTexParameteri(target, pname, param); }
    }

    public static void TexParameter(TextureTarget target, TextureParameter pname, params float[] parameters) {
        unsafe { fixed (GLfloat* ptr = parameters) gl.Functions.glTexParameterfv(target, pname, ptr); }
    }

    public static void TexParameter(TextureTarget target, TextureParameter pname, params int[] parameters) {
        unsafe { fixed (GLint* ptr = parameters) gl.Functions.glTexParameteriv(target, pname, ptr); }
    }

    public static void TexParameterI(TextureTarget target, TextureParameter pname, params int[] parameters) {
        unsafe { fixed (GLint* ptr = parameters) gl.Functions.glTexParameterIiv(target, pname, ptr); }
    }

    public static void TexParameterI(TextureTarget target, TextureParameter pname, params uint[] parameters) {
        unsafe { fixed (GLuint* ptr = parameters) gl.Functions.glTexParameterIuiv(target, pname, ptr); }
    }

    public static void TextureParameterf(this GLtexture texture, TextureParameter pname, float param) {
        unsafe { gl.Functions.glTextureParameterf(texture, pname, param); }
    }

    public static void TextureParameteri(this GLtexture texture, TextureParameter pname, int param) {
        unsafe { gl.Functions.glTextureParameteri(texture, pname, param); }
    }

    public static void TextureParameter(this GLtexture texture, TextureParameter pname, params float[] parameters) {
        unsafe { fixed (GLfloat* ptr = parameters) gl.Functions.glTextureParameterfv(texture, pname, ptr); }
    }

    public static void TextureParameter(this GLtexture texture, TextureParameter pname, params int[] parameters) {
        unsafe { fixed (GLint* ptr = parameters) gl.Functions.glTextureParameteriv(texture, pname, ptr); }
    }

    public static void TextureParameterI(this GLtexture texture, TextureParameter pname, params int[] parameters) {
        unsafe { fixed (GLint* ptr = parameters) gl.Functions.glTextureParameterIiv(texture, pname, ptr); }
    }

    public static void TextureParameterI(this GLtexture texture, TextureParameter pname, params uint[] parameters) {
        unsafe { fixed (GLuint* ptr = parameters) gl.Functions.glTextureParameterIuiv(texture, pname, ptr); }
    }

    public static void TexStorage1D(TextureTarget target, int levels, SizedInternalFormat internalFormat, int width) {
        unsafe { gl.Functions.glTexStorage1D(target, levels, internalFormat, width); }
    }

    public static void TextureStorage1D(this GLtexture texture, int levels, SizedInternalFormat internalFormat, int width) {
        unsafe { gl.Functions.glTextureStorage1D(texture, levels, internalFormat, width); }
    }

    public static void TexStorage2D(TextureTarget target, int levels, SizedInternalFormat internalFormat, int width, int height) {
        unsafe { gl.Functions.glTexStorage2D(target, levels, internalFormat, width, height); }
    }

    public static void TextureStorage2D(this GLtexture texture, int levels, SizedInternalFormat internalFormat, int width, int height) {
        unsafe { gl.Functions.glTextureStorage2D(texture, levels, internalFormat, width, height); }
    }

    public static void TexStorage2DMultisample(TextureTarget target, int levels, SizedInternalFormat internalFormat, int width, int height, bool fixedsamplelocations) {
        unsafe { gl.Functions.glTexStorage2DMultisample(target, levels, internalFormat, width, height, (GLboolean)(fixedsamplelocations ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE)); }
    }

    public static void TextureStorage2DMultisample(this GLtexture texture, int levels, SizedInternalFormat internalFormat, int width, int height, bool fixedsamplelocations) {
        unsafe { gl.Functions.glTextureStorage2DMultisample(texture, levels, internalFormat, width, height, (GLboolean)(fixedsamplelocations ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE)); }
    }

    public static void TexStorage3D(TextureTarget target, int levels, SizedInternalFormat internalFormat, int width, int height, int depth) {
        unsafe { gl.Functions.glTexStorage3D(target, levels, internalFormat, width, height, depth); }
    }

    public static void TextureStorage3D(this GLtexture texture, int levels, SizedInternalFormat internalFormat, int width, int height, int depth) {
        unsafe { gl.Functions.glTextureStorage3D(texture, levels, internalFormat, width, height, depth); }
    }

    public static void TexStorage3DMultisample(TextureTarget target, int levels, SizedInternalFormat internalFormat, int width, int height, int depth, bool fixedsamplelocations) {
        unsafe { gl.Functions.glTexStorage3DMultisample(target, levels, internalFormat, width, height, depth, (GLboolean)(fixedsamplelocations ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE)); }
    }

    public static void TextureStorage3DMultisample(this GLtexture texture, int levels, SizedInternalFormat internalFormat, int width, int height, int depth, bool fixedsamplelocations) {
        unsafe { gl.Functions.glTextureStorage3DMultisample(texture, levels, internalFormat, width, height, depth, (GLboolean)(fixedsamplelocations ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE)); }
    }

    public static void TexSubImage1D<T>(TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, T[] pixels) where T : unmanaged {
        unsafe { fixed (void* ptr = pixels) gl.Functions.glTexSubImage1D(target, level, xoffset, width, format, type, ptr); }
    }

    public static void TextureSubImage1D<T>(this GLtexture texture, int level, int xoffset, int width, PixelFormat format, PixelType type, T[] pixels) where T : unmanaged {
        unsafe { fixed (void* ptr = pixels) gl.Functions.glTextureSubImage1D(texture, level, xoffset, width, format, type, ptr); }
    }

    public static void TexSubImage2D<T>(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, T[] pixels) where T : unmanaged {
        unsafe { fixed (void* ptr = pixels) gl.Functions.glTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, ptr); }
    }

    public static void TextureSubImage2D<T>(this GLtexture texture, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, T[] pixels) where T : unmanaged {
        unsafe { fixed (void* ptr = pixels) gl.Functions.glTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, ptr); }
    }

    public static void TexSubImage3D<T>(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, T[] pixels) where T : unmanaged {
        unsafe { fixed (void* ptr = pixels) gl.Functions.glTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, ptr); }
    }

    public static void TextureSubImage3D<T>(this GLtexture texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, T[] pixels) where T : unmanaged {
        unsafe { fixed (void* ptr = pixels) gl.Functions.glTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, ptr); }
    }

    public static void TextureView(this GLtexture texture, TextureTarget target, GLtexture origTexture, SizedInternalFormat internalFormat, int minLevel, int levelCount, int minLayer, int layerCount) {
        unsafe { gl.Functions.glTextureView(texture, target, origTexture, internalFormat, (GLuint)minLevel, (GLuint)levelCount, (GLuint)minLayer, (GLuint)layerCount); }
    }
}