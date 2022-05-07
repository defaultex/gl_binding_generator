#if (GL_OES_point_size_array && !gles1)
public partial class gles1 { 
    public partial class Functions { 
        /// <summary>void glPointSizePointerOES(GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLsizei, void*, void> glPointSizePointerOES;
    }
}
#endif