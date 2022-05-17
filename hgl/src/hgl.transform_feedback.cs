partial class hgl {

    public static void BeginTransformFeedback(PrimitiveType mode) {
        unsafe { gl.Functions.glBeginTransformFeedback(mode); }
    }

    // glBindTransformFeedback
    // glCreateTransformFeedbacks
    // glDeleteTransformFeedbacks
    // glDrawTransformFeedback
    // glDrawTransformFeedbackInstanced
    // glDrawTransformFeedbackStream
    // glDrawTransformFeedbackStreamInstanced

    public static void EndTransformFeedback() {
        unsafe { gl.Functions.glEndTransformFeedback(); }
    }

    // glGenTransformFeedbacks
    // glGetTransformFeedback

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

    // glIsTransformFeedback
    // glPauseTransformFeedback
    // glResumeTransformFeedback
    // glTransformFeedbackBufferBase
    // glTransformFeedbackBufferRange

    // TODO : validate this method actually works, have a strong feeling it doesn't
    public static void glTransformFeedbackVaryings(GLprogram program, int count, string[] varyings, TransformFeedbackBufferMode bufferMode) {
        unsafe {
            GLchar** varray = stackalloc GLchar*[varyings.Length];
            for (int i = 0; i < varyings.Length; i++) {
                // note: doing a stackalloc here says 'unable to convert byte* to byte*' as there are two unique 'byte*' types
                byte[] vstr = Encoding.UTF8.GetBytes(varyings[i]);
                fixed (GLchar* vstrPtr = vstr) varray[i] = vstrPtr;
            }
            gl.Functions.glTransformFeedbackVaryings(program, (GLsizei)count, varray, bufferMode);
        }
    }
}