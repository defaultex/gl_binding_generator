partial class hgl {

    public static void BindFramebuffer(FramebufferTarget target, GLframebuffer framebuffer) {
        unsafe { gl.Functions.glBindFramebuffer(target, framebuffer); }
    }

    public static void BindRenderbuffer(this GLrenderbuffer renderbuffer) {
        unsafe { gl.Functions.glBindRenderbuffer(RenderbufferTarget.Renderbuffer, renderbuffer); }
    }

    public static void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, MagFilter filter) {
        unsafe { gl.Functions.glBlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter); }
    }

    public static void BlitFramebuffer(GLframebuffer readBuffer, GLframebuffer drawBuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, MagFilter filter) {
        unsafe { gl.Functions.glBlitNamedFramebuffer(readBuffer, drawBuffer, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter); }
    }

    public static FramebufferStatus CheckFramebufferStatus(FramebufferTarget target) {
        unsafe { return gl.Functions.glCheckFramebufferStatus(target); }
    }

    public static FramebufferStatus CheckFramebufferStatus(this GLframebuffer buffer, FramebufferTarget target) {
        unsafe { return gl.Functions.glCheckNamedFramebufferStatus(buffer, target); }
    }

    public static void CreateFramebuffers(GLframebuffer[] framebuffers) {
        unsafe { fixed (GLframebuffer* ptr = framebuffers) gl.Functions.glCreateFramebuffers(framebuffers.Length, ptr); }
    }
    
    public static void CreateFramebuffer(out GLframebuffer framebuffer) {
        unsafe { fixed (GLframebuffer* ptr = &framebuffer) gl.Functions.glCreateFramebuffers(1, ptr); }
    }

    public static void CreateRenderbuffers(GLrenderbuffer[] renderbuffers) {
        unsafe { fixed (GLrenderbuffer* ptr = renderbuffers) gl.Functions.glCreateRenderbuffers(renderbuffers.Length, ptr); }
    }

    public static void CreateRenderbuffer(out GLrenderbuffer renderbuffer) {
        unsafe { fixed (GLrenderbuffer* ptr = &renderbuffer) gl.Functions.glCreateRenderbuffers(1, ptr); }
    }

    public static void DeleteFramebuffers(params GLframebuffer[] framebuffers) {
        unsafe { fixed (GLframebuffer* ptr = framebuffers) gl.Functions.glDeleteFramebuffers(framebuffers.Length, ptr); }
    }

    public static void DeleteRenderbuffers(params GLrenderbuffer[] renderbuffers) {
        unsafe { fixed (GLrenderbuffer* ptr = renderbuffers) gl.Functions.glDeleteRenderbuffers(renderbuffers.Length, ptr); }
    }

    public static void DrawBuffers(params ColorBuffer[] buffers) {
        unsafe { fixed (ColorBuffer* ptr = buffers) gl.Functions.glDrawBuffers(buffers.Length, ptr); }
    }

    public static void DrawBuffers(this GLframebuffer buffer, params ColorBuffer[] buffers) {
        unsafe { fixed (ColorBuffer* ptr = buffers) gl.Functions.glNamedFramebufferDrawBuffers(buffer, buffers.Length, ptr); }
    }

    public static void FramebufferParameter(FramebufferTarget target, FramebufferParameter pname, int param) {
        unsafe { gl.Functions.glFramebufferParameteri(target, pname, param); }
    }

    public static void FramebufferParameter(this GLframebuffer buffer, FramebufferParameter pname, int param) {
        unsafe { gl.Functions.glNamedFramebufferParameteri(buffer, pname, param); }
    }

    public static void FramebufferRenderbuffer(FramebufferTarget target, FramebufferAttachment attachment, GLrenderbuffer renderbuffer) {
        unsafe { gl.Functions.glFramebufferRenderbuffer(target, attachment, RenderbufferTarget.Renderbuffer, renderbuffer); }
    }

    public static void FramebufferRenderbuffer(this GLframebuffer buffer, FramebufferAttachment attachment, GLrenderbuffer renderbuffer) {
        unsafe { gl.Functions.glNamedFramebufferRenderbuffer(buffer, attachment, RenderbufferTarget.Renderbuffer, renderbuffer); }
    }

    public static void FramebufferTexture(FramebufferTarget target, FramebufferAttachment attachment, GLtexture texture, int level) {
        unsafe { gl.Functions.glFramebufferTexture(target, attachment, texture, (GLint)level); }
    }

    public static void FramebufferTexture1D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, GLtexture texture, int level) {
        unsafe { gl.Functions.glFramebufferTexture1D(target, attachment, textarget, texture, (GLint)level); }
    }

    public static void FramebufferTexture2D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, GLtexture texture, int level) {
        unsafe { gl.Functions.glFramebufferTexture2D(target, attachment, textarget, texture, (GLint)level); }
    }

    public static void FramebufferTexture3D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, GLtexture texture, int level, int zoffset) {
        unsafe { gl.Functions.glFramebufferTexture3D(target, attachment, textarget, texture, (GLint)level, (GLint)zoffset); }
    }

    public static void FramebufferTexture(this GLframebuffer buffer, FramebufferAttachment attachment, GLtexture texture, int level) {
        unsafe { gl.Functions.glNamedFramebufferTexture(buffer, attachment, texture, (GLint)level); }
    }

    public static void FramebufferTextureLayer(FramebufferTarget target, FramebufferAttachment attachment, GLtexture texture, int level, int layer) {
        unsafe { gl.Functions.glFramebufferTextureLayer(target, attachment, texture, level, layer); }
    }

    public static void FramebufferTextureLayer(this GLframebuffer buffer, FramebufferAttachment attachment, GLtexture texture, int level, int layer) {
        unsafe { gl.Functions.glNamedFramebufferTextureLayer(buffer, attachment, texture, level, layer); }
    }

    public static void GenFramebuffers(GLframebuffer[] framebuffers) {
        unsafe { fixed (GLframebuffer* ptr = framebuffers) gl.Functions.glGenFramebuffers(framebuffers.Length, ptr); }
    }

    public static void GenFramebuffers(out GLframebuffer framebuffer) {
        unsafe { fixed (GLframebuffer* ptr = &framebuffer) gl.Functions.glGenFramebuffers(1, ptr); }
    }

    public static void GenRenderbuffers(GLrenderbuffer[] renderbuffers) {
        unsafe { fixed (GLrenderbuffer* ptr = renderbuffers) gl.Functions.glGenRenderbuffers(renderbuffers.Length, ptr); }
    }

    public static void GenRenderbuffers(out GLrenderbuffer renderbuffer) {
        unsafe { fixed (GLrenderbuffer* ptr = &renderbuffer) gl.Functions.glGenRenderbuffers(1, ptr); }
    }

    public static void GenerateMipmap(TextureTarget target) {
        unsafe { gl.Functions.glGenerateMipmap(target); }
    }

    public static void GenerateMipmap(GLtexture texture) {
        unsafe { gl.Functions.glGenerateTextureMipmap(texture); }
    }

    public static void GetFramebufferAttachmentParameter(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameter pname, out int parameters) {
        unsafe { fixed (GLint* ptr = &parameters) gl.Functions.glGetFramebufferAttachmentParameteriv(target, attachment, pname, ptr); }
    }

    public static void GetFramebufferAttachmentParameter(this GLframebuffer buffer, FramebufferAttachment attachment, FramebufferAttachmentParameter pname, out int parameters) {
        unsafe { fixed (GLint* ptr = &parameters) gl.Functions.glGetNamedFramebufferAttachmentParameteriv(buffer, attachment, pname, ptr); }
    }

    public static void GetFramebufferParameter(FramebufferTarget target, FramebufferAttachmentParameter pname, out int parameters) {
        unsafe { fixed (GLint* ptr = &parameters) gl.Functions.glGetFramebufferParameteriv(target, pname, ptr); }
    }

    public static void GetFramebufferParameter(this GLframebuffer buffer, FramebufferParameter pname, out int parameters) {
        unsafe { fixed (GLint* ptr = &parameters) gl.Functions.glGetNamedFramebufferParameteriv(buffer, pname, ptr); }
    }

    public static void GetRenderbufferParameter(RenderbufferParameter pname, out GLint parameters) {
        unsafe { fixed (GLint* ptr = &parameters) gl.Functions.glGetRenderbufferParameteriv(RenderbufferTarget.Renderbuffer, pname, ptr); }
    }

    public static void GetRenderbufferParameter(this GLrenderbuffer buffer, RenderbufferParameter pname, out GLint parameters) {
        unsafe { fixed (GLint* ptr = &parameters) gl.Functions.glGetNamedRenderbufferParameteriv(buffer, pname, ptr); }
    }

    public static void InvalidateFramebuffer(FramebufferTarget target, FramebufferAttachment[] attachments) {
        unsafe { fixed (FramebufferAttachment* pAttach = attachments) gl.Functions.glInvalidateFramebuffer(target, attachments.Length, pAttach); }
    }

    public static void InvalidateFramebuffer(this GLframebuffer buffer, FramebufferAttachment[] attachments) {
        unsafe { fixed (FramebufferAttachment* pAttach = attachments) gl.Functions.glInvalidateNamedFramebufferData(buffer, attachments.Length, pAttach); }
    }

    public static void InvalidateSubFramebuffer(FramebufferTarget target, FramebufferAttachment[] attachments, int x, int y, int width, int height) {
        unsafe { fixed (FramebufferAttachment* pAttach = attachments) gl.Functions.glInvalidateSubFramebuffer(target, attachments.Length, pAttach, x, y, width, height); }
    }

    public static void InvalidateSubFramebuffer(this GLframebuffer buffer, FramebufferAttachment[] attachments, int x, int y, int width, int height) {
        unsafe { fixed (FramebufferAttachment* pAttach = attachments) gl.Functions.glInvalidateNamedFramebufferSubData(buffer, attachments.Length, pAttach, x, y, width, height); }
    }

    public static GLboolean IsFramebuffer(this GLframebuffer framebuffer) {
        unsafe { return gl.Functions.glIsFramebuffer(framebuffer); }
    }

    public static GLboolean IsRenderbuffer(this GLrenderbuffer renderbuffer) {
        unsafe { return gl.Functions.glIsRenderbuffer(renderbuffer); }
    }

    public static void RenderbufferStorage(InternalFormat internalformat, int width, int height) {
        unsafe { gl.Functions.glRenderbufferStorage(RenderbufferTarget.Renderbuffer, internalformat, width, height); }
    }

    public static void RenderbufferStorage(this GLrenderbuffer buffer, InternalFormat internalformat, int width, int height) {
        unsafe { gl.Functions.glNamedRenderbufferStorage(buffer, internalformat, width, height); }
    }

    public static void RenderbufferStorageMultisample(int samples, InternalFormat internalformat, int width, int height) {
        unsafe { gl.Functions.glRenderbufferStorageMultisample(RenderbufferTarget.Renderbuffer, samples, internalformat, width, height); }
    }

    public static void RenderbufferStorageMultisample(this GLrenderbuffer buffer, int samples, InternalFormat internalformat, int width, int height) {
        unsafe { gl.Functions.glNamedRenderbufferStorageMultisample(buffer, samples, internalformat, width, height); }
    }

    public static void SampleMask(GLuint maskNumber, GLbitfield mask) {
        unsafe { gl.Functions.glSampleMaski(maskNumber, mask); }
    }
}