namespace HGL;

public static partial class hgl {

    public static void BeginTransformFeedback(PrimitiveType mode) {
        unsafe { gl.Functions.glBeginTransformFeedback(mode); }
    }

    public static void BindTransformFeedback(BindTransformFeedbackTarget target, GLtransformfeedback xfb) {
        unsafe { gl.Functions.glBindTransformFeedback(target, xfb); }
    }

    public static void CreateTransformFeedbacks(GLtransformfeedback[] xfbs) {
        unsafe { fixed (GLtransformfeedback* pIds = xfbs) gl.Functions.glCreateTransformFeedbacks(xfbs.Length, pIds); }
    }

    public static void CreateTransformFeedbacks(out GLtransformfeedback xfb) {
        unsafe { fixed (GLtransformfeedback* pIds = &xfb) gl.Functions.glCreateTransformFeedbacks(1, pIds); }
    }

    public static void DeleteTransformFeedbacks(params GLtransformfeedback[] xfbs) {
        unsafe { fixed (GLtransformfeedback* pIds = xfbs) gl.Functions.glDeleteTransformFeedbacks(xfbs.Length, pIds); }
    }

    public static void DrawTransformFeedback(PrimitiveType mode, GLtransformfeedback xfb) {
        unsafe { gl.Functions.glDrawTransformFeedback(mode, xfb); }
    }

    public static void DrawTransformFeedbackInstanced(PrimitiveType mode, GLtransformfeedback xfb, int instanceCount) {
        unsafe { gl.Functions.glDrawTransformFeedbackInstanced(mode, xfb, instanceCount); }
    }

    public static void DrawTransformFeedbackStream(PrimitiveType mode, GLtransformfeedback xfb, int stream) {
        unsafe { gl.Functions.glDrawTransformFeedbackStream(mode, xfb, (GLuint)stream); }
    }

    public static void DrawTransformFeedbackStream(PrimitiveType mode, GLtransformfeedback xfb, int stream, int instanceCount) {
        unsafe { gl.Functions.glDrawTransformFeedbackStreamInstanced(mode, xfb, (GLuint)stream, instanceCount); }
    }

    public static void EndTransformFeedback() {
        unsafe { gl.Functions.glEndTransformFeedback(); }
    }

    public static void GenTransformFeedbacks(GLtransformfeedback[] xfbs) {
        unsafe { fixed (GLtransformfeedback* pIds = xfbs) gl.Functions.glGenTransformFeedbacks(xfbs.Length, pIds); }
    }

    public static void GenTransformFeedbacks(out GLtransformfeedback xfbs) {
        unsafe { fixed (GLtransformfeedback* pIds = &xfbs) gl.Functions.glGenTransformFeedbacks(1, pIds); }
    }

    public static void GetTransformFeedback(this GLtransformfeedback xfb, TransformFeedbackParameter pname, int[] parameters) {
        unsafe { fixed (GLint* pParams = parameters) gl.Functions.glGetTransformFeedbackiv(xfb, pname, pParams); }
    }

    public static void GetTransformFeedback(this GLtransformfeedback xfd, TransformFeedbackParameter pname, out int parameters) {
        unsafe { fixed (GLint* pParams = &parameters) gl.Functions.glGetTransformFeedbackiv(xfd, pname, pParams); }
    }

    public static void GetTransformFeedback(this GLtransformfeedback xfb, TransformFeedbackParameter pname, int index, int[] parameters) {
        unsafe { fixed (GLint* pParams = parameters) gl.Functions.glGetTransformFeedbacki_v(xfb, pname, (GLuint)index, pParams); }
    }

    public static void GetTransformFeedback(this GLtransformfeedback xfd, TransformFeedbackParameter pname, int index, out int parameters) {
        unsafe { fixed (GLint* pParams = &parameters) gl.Functions.glGetTransformFeedbacki_v(xfd, pname, (GLuint)index, pParams); }
    }

    public static void GetTransformFeedback(this GLtransformfeedback xfb, TransformFeedbackParameter pname, int index, long[] parameters) {
        unsafe { fixed (GLint64* pParams = parameters) gl.Functions.glGetTransformFeedbacki64_v(xfb, pname, (GLuint)index, pParams); }
    }

    public static void GetTransformFeedback(this GLtransformfeedback xfd, TransformFeedbackParameter pname, int index, out long parameters) {
        unsafe { fixed (GLint64* pParams = &parameters) gl.Functions.glGetTransformFeedbacki64_v(xfd, pname, (GLuint)index, pParams); }
    }

    public static void GetTransformFeedbackVarying(GLprogram program, int index, int bufSize, out GLsizei size, out AttributeType type, out string name) {
        unsafe {
            GLsizei length = bufSize;
            GLchar* cstring = stackalloc GLchar[bufSize];
            fixed (GLint* psize = &size) fixed (AttributeType* ptype = &type) {
                gl.Functions.glGetTransformFeedbackVarying(program, (GLuint)index, bufSize, &length, psize, ptype, cstring);
            }
            name = Encoding.UTF8.GetString(cstring, length);
        }
    }

    public static bool IsTransformFeedback(this GLtransformfeedback xfb) {
        unsafe { return (gl.Functions.glIsTransformFeedback(xfb) != gl.Constants.GL_FALSE); }
    }

    public static void PauseTransformFeedback() {
        unsafe { gl.Functions.glPauseTransformFeedback(); }
    }

    public static void ResumeTransformFeedback() {
        unsafe { gl.Functions.glResumeTransformFeedback(); }
    }

    public static void TransformFeedbackBufferBase(this GLtransformfeedback xfb, int index, GLbuffer buffer) {
        unsafe { gl.Functions.glTransformFeedbackBufferBase(xfb, (GLuint)index, buffer); }
    }

    public static void TransformFeedbackBufferRange(this GLtransformfeedback xfb, int index, GLbuffer buffer, int offset, int size) {
        unsafe { gl.Functions.glTransformFeedbackBufferRange(xfb, (GLuint)index, buffer, (GLintptr)offset, (GLsizeiptr)size); }
    }

    public static void TransformFeedbackVaryings(GLprogram program, int count, string[] varyings, TransformFeedbackBufferMode bufferMode) {
        unsafe {
            GLchar** ppArray = stackalloc GLchar*[varyings.Length];
            for (int i = 0; i < varyings.Length; i++) {
#pragma warning disable CA2014
                GLchar* pStr = stackalloc GLchar[varyings[i].Length];
#pragma warning restore CA2014
                byte[] bStr = Encoding.UTF8.GetBytes(varyings[i]);
                fixed (GLchar* vStr = bStr) {
                    System.Buffer.MemoryCopy(vStr, pStr, bStr.Length, bStr.Length);
                }
                ppArray[i] = pStr;
            }
            gl.Functions.glTransformFeedbackVaryings(program, (GLsizei)count, ppArray, bufferMode);
        }
    }
}