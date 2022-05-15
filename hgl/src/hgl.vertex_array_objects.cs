partial class hgl {
    
    public static void BindVertexArray(GLvertexarray array) {
        unsafe { gl.Functions.glBindVertexArray(array); }
    }

    public static void DeleteVertexArrays(params GLvertexarray[] arrays) {
        unsafe { fixed (GLvertexarray* ptr = arrays) gl.Functions.glDeleteVertexArrays(arrays.Length, ptr); }
    }

    public static void GenVertexArrays(GLvertexarray[] arrays) {
        unsafe { fixed (GLvertexarray* ptr = arrays) gl.Functions.glGenVertexArrays(arrays.Length, ptr); }
    }

    public static void GenVertexArrays(out GLvertexarray array) {
        unsafe { fixed (GLvertexarray* ptr = &array) gl.Functions.glGenVertexArrays(1, ptr); }
    }

    public static GLboolean IsVertexArray(GLvertexarray array) {
        unsafe { return gl.Functions.glIsVertexArray(array); }
    }
}