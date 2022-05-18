namespace HGL;

partial class hgl {

    public static void Clear(ClearBufferMask mask) {
        unsafe { gl.Functions.glClear(mask); }
    }

    public static void ClearBuffer(Buffer buffer, int drawBuffer, params int[] value) {
        unsafe { fixed (GLint* ptr = value) gl.Functions.glClearBufferiv(buffer, drawBuffer, ptr); }
    }

    public static void ClearBuffer(Buffer buffer, int drawBuffer, params uint[] value) {
        unsafe { fixed (GLuint* ptr = value) gl.Functions.glClearBufferuiv(buffer, drawBuffer, ptr); }
    }

    public static void ClearBuffer(Buffer buffer, int drawBuffer, params float[] value) {
        unsafe { fixed (GLfloat* ptr = value) gl.Functions.glClearBufferfv(buffer, drawBuffer, ptr); }
    }

    // TODO : create a fix to the generator to allow bit mask for this particular usage
    public static void ClearBuffer(float depth, int stencil) {
        unsafe { gl.Functions.glClearBufferfi(Buffer.Depth | Buffer.Stencil, 0, depth, (GLint)stencil); }
    }

    public static void ClearBuffer(this GLframebuffer framebuffer, Buffer buffer, int drawBuffer, params int[] value) {
        unsafe { fixed (GLint* ptr = value) gl.Functions.glClearNamedFramebufferiv(framebuffer, buffer, drawBuffer, ptr); }
    }

    public static void ClearBuffer(this GLframebuffer framebuffer, Buffer buffer, int drawBuffer, params uint[] value) {
        unsafe { fixed (GLuint* ptr = value) gl.Functions.glClearNamedFramebufferuiv(framebuffer, buffer, drawBuffer, ptr); }
    }

    public static void ClearBuffer(this GLframebuffer framebuffer, Buffer buffer, int drawBuffer, params float[] value) {
        unsafe { fixed (GLfloat* ptr = value) gl.Functions.glClearNamedFramebufferfv(framebuffer, buffer, drawBuffer, ptr); }
    }

    // TODO : create a fix to the generator to allow bit mask for this particular usage
    public static void ClearBuffer(this GLframebuffer framebuffer, float depth, int stencil) {
        unsafe { gl.Functions.glClearNamedFramebufferfi(framebuffer, Buffer.Depth | Buffer.Stencil, 0, depth, (GLint)stencil); }
    }

    public static void ClearColor(float red, float green, float blue, float alpha) {
        unsafe { gl.Functions.glClearColor(red, green, blue, alpha); }
    }

    public static void ClearDepth(double depth) {
        unsafe { gl.Functions.glClearDepth(depth); }
    }

    public static void ClearDepth(float depth) {
        unsafe { gl.Functions.glClearDepthf(depth); }
    }

    public static void ClearStencil(int stencil) {
        unsafe { gl.Functions.glClearStencil(stencil); }
    }

    public static void DrawBuffer(ColorBuffer mode) {
        unsafe { gl.Functions.glDrawBuffer(mode); }
    }

    public static void Finish() {
        unsafe { gl.Functions.glFinish(); }
    }

    public static void glFlush() {
        unsafe { gl.Functions.glFlush(); }
    }

    public static void ReadBuffer(ColorBuffer mode) {
        unsafe { gl.Functions.glReadBuffer(mode); }
    }

    public static void ReadBuffer(this GLframebuffer buffer, ColorBuffer mode) {
        unsafe { gl.Functions.glNamedFramebufferReadBuffer(buffer, mode); }
    }

    public static void ReadPixels<T>(int x, int y, int width, int height, PixelFormat format, PixelType type, T[] pixels) where T : unmanaged {
        unsafe { fixed (void* ptr = pixels) gl.Functions.glReadPixels(x, y, width, height, format, type, ptr); }
    }

    public static void ReadNPixels<T>(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, T[] pixels) where T : unmanaged {
        unsafe { fixed (void* ptr = pixels) gl.Functions.glReadnPixels(x, y, width, height, format, type, bufSize, ptr); }
    }
}