namespace HGL;

public static partial class hgl {
    public static void DispatchCompute(int groupCountX, int groupCountY, int groupCountZ) {
        unsafe { gl.Functions.glDispatchCompute((GLuint)groupCountX, (GLuint)groupCountY, (GLuint)groupCountZ); }
    }

    public static void DispatchComputeIndirect(int indirect) {
        unsafe { gl.Functions.glDispatchComputeIndirect((GLintptr)indirect); }
    }

    public static GraphicsResetStatus GetGraphicsResetStatus() {
        unsafe { return gl.Functions.glGetGraphicsResetStatus(); }
    }

    public static void GetInternalFormat(TextureTarget target, InternalFormat internalFormat, InternalFormatParameter pname, int[] parameters) {
        unsafe { fixed (GLint* pParams = parameters) gl.Functions.glGetInternalformativ(target, internalFormat, pname, parameters.Length, pParams); }
    }

    public static void GetInternalFormat(TextureTarget target, InternalFormat internalFormat, InternalFormatParameter pname, long[] parameters) {
        unsafe { fixed (GLint64* pParams = parameters) gl.Functions.glGetInternalformati64v(target, internalFormat, pname, parameters.Length, pParams); }
    }

    public static string GetString(GLString name) {
        unsafe { return Marshal.PtrToStringUTF8((IntPtr)gl.Functions.glGetString(name)); }
    }

    public static string GetString(GLString name, int index) {
        unsafe { return Marshal.PtrToStringUTF8((IntPtr)gl.Functions.glGetStringi(name, (GLuint)index)); }
    }

    public static void GetMultisample(GLuint index, GLfloat[] value) {
        unsafe { fixed (GLfloat* ptr = value) { gl.Functions.glGetMultisamplefv(MultisampleParameter.SamplePosition, index, ptr); } }
    }

    public static void GetMultisample(GLuint index, out GLfloat x, out GLfloat y) {
        x = y = default;
        unsafe { fixed (GLfloat* ptr = &x) { gl.Functions.glGetMultisamplefv(MultisampleParameter.SamplePosition, index, ptr); } }
    }

    public static void GetMultisample(GLuint index, out ValueTuple<GLfloat, GLfloat> value) {
        value = default;
        unsafe { fixed (GLfloat* ptr = &value.Item1) { gl.Functions.glGetMultisamplefv(MultisampleParameter.SamplePosition, index, ptr); } }
    }

    public static void MemoryBarrier(MemoryBarrierMask barriers) {
        unsafe { gl.Functions.glMemoryBarrier(barriers); }
    }

    public static void MemoryBarrierByRegion(MemoryBarrierMask barriers) {
        unsafe { gl.Functions.glMemoryBarrierByRegion(barriers); }
    }
}