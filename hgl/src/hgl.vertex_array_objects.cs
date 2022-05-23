namespace HGL;

public static partial class hgl {
    
    public static void BindVertexArray(this GLvertexarray array) {
        unsafe { gl.Functions.glBindVertexArray(array); }
    }

    public static void BindVertexBuffer(this GLvertexarray vaobj, int bindingIndex, GLbuffer buffer, int offset, int size) {
        unsafe { gl.Functions.glVertexArrayVertexBuffer(vaobj, (GLuint)bindingIndex, buffer, (GLintptr)offset, size); }
    }

    public static void BindVertexBuffers(this GLvertexarray vaobj, int bindingIndex, GLbuffer[] buffers, int[] offsets, int[] sizes) {
        unsafe {
            fixed (GLbuffer* pBuffers = buffers)
            fixed (int* pOffsets = offsets, pSizes = sizes) {
                gl.Functions.glVertexArrayVertexBuffers(vaobj, (GLuint)bindingIndex, buffers.Length, pBuffers, (GLintptr*)pOffsets, pSizes);
            }
        }
    }

    public static void CreateVertexArrays(GLvertexarray[] arrays) {
        unsafe { fixed (GLvertexarray* pArrays = arrays) gl.Functions.glCreateVertexArrays(arrays.Length, pArrays); }
    }

    public static void CreateVertexArray(out GLvertexarray arrays) {
        unsafe { fixed (GLvertexarray* pArrays = &arrays) gl.Functions.glCreateVertexArrays(1, pArrays); }
    }

    public static void DeleteVertexArrays(params GLvertexarray[] arrays) {
        unsafe { fixed (GLvertexarray* ptr = arrays) gl.Functions.glDeleteVertexArrays(arrays.Length, ptr); }
    }

    public static void DisableVertexAttribArray(this GLvertexarray vaobj, int index) {
        unsafe { gl.Functions.glDisableVertexArrayAttrib(vaobj, (GLuint)index); }
    }

    public static void EnableVertexAttribArray(this GLvertexarray vaobj, int index) {
        unsafe { gl.Functions.glEnableVertexArrayAttrib(vaobj, (GLuint)index); }
    }

    public static void GenVertexArrays(GLvertexarray[] arrays) {
        unsafe { fixed (GLvertexarray* ptr = arrays) gl.Functions.glGenVertexArrays(arrays.Length, ptr); }
    }

    public static void GenVertexArrays(out GLvertexarray array) {
        unsafe { fixed (GLvertexarray* ptr = &array) gl.Functions.glGenVertexArrays(1, ptr); }
    }

    public static void GetVertexArrayIndexed(this GLvertexarray vaobj, int index, VertexArrayParameter pname, int[] parameters) {
        unsafe { fixed (GLint* pParam = parameters) gl.Functions.glGetVertexArrayIndexediv(vaobj, (GLuint)index, pname, pParam); }
    }

    public static void GetVertexArrayIndexed(this GLvertexarray vaobj, int index, VertexArrayParameter pname, out int parameters) {
        unsafe { fixed (GLint* pParam = &parameters) gl.Functions.glGetVertexArrayIndexediv(vaobj, (GLuint)index, pname, pParam); }
    }

    public static void GetVertexArrayIndexed(this GLvertexarray vaobj, int index, VertexArrayParameter pname, long[] parameters) {
        unsafe { fixed (GLint64* pParam = parameters) gl.Functions.glGetVertexArrayIndexed64iv(vaobj, (GLuint)index, pname, pParam); }
    }

    public static void GetVertexArrayIndexed(this GLvertexarray vaobj, int index, VertexArrayParameter pname, out long parameters) {
        unsafe { fixed (GLint64* pParam = &parameters) gl.Functions.glGetVertexArrayIndexed64iv(vaobj, (GLuint)index, pname, pParam); }
    }

    public static void GetVertexArray(this GLvertexarray vaobj, VertexArrayParameter pname, int[] parameters) {
        unsafe { fixed (GLint* pParam = parameters) gl.Functions.glGetVertexArrayiv(vaobj, pname, pParam); }
    }

    public static void GetVertexArray(this GLvertexarray vaobj, VertexArrayParameter pname, out int parameters) {
        unsafe { fixed (GLint* pParam = &parameters) gl.Functions.glGetVertexArrayiv(vaobj, pname, pParam); }
    }

    public static bool IsVertexArray(this GLvertexarray array) {
        unsafe { return (gl.Functions.glIsVertexArray(array) != gl.Constants.GL_FALSE); }
    }

    public static void VertexArrayElementBuffer(this GLvertexarray vaobj, GLbuffer buffer) {
        unsafe { gl.Functions.glVertexArrayElementBuffer(vaobj, buffer); }
    }

    public static void VertexAttribBinding(this GLvertexarray vaobj, int attribIndex, int bindingIndex) {
        unsafe { gl.Functions.glVertexArrayAttribBinding(vaobj, (GLuint)attribIndex, (GLuint)bindingIndex); }
    }

    public static void VertexAttribFormat(this GLvertexarray vaobj, int attribIndex, int size, VertexAttribType type, bool normalized, int relOffset) {
        unsafe { gl.Functions.glVertexArrayAttribFormat(vaobj, (GLuint)attribIndex, size, type, (GLboolean)(normalized ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), (GLuint)relOffset); }
    }

    public static void VertexAttribIFormat(this GLvertexarray vaobj,int attribIndex, int size, VertexAttribType type, int relOffset) {
        unsafe { gl.Functions.glVertexArrayAttribIFormat(vaobj, (GLuint)attribIndex, size, type, (GLuint)relOffset); }
    }

    public static void VertexAttribLFormat(this GLvertexarray vaobj,int attribIndex, int size, VertexAttribType type, int relOffset) {
        unsafe { gl.Functions.glVertexArrayAttribLFormat(vaobj, (GLuint)attribIndex, size, type, (GLuint)relOffset); }
    }

    public static void VertexBindingDivisor(this GLvertexarray vaobj, int index, int divisor) {
        unsafe { gl.Functions.glVertexArrayBindingDivisor(vaobj, (GLuint)index, (GLuint)divisor); }
    }
}