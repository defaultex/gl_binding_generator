#if (GL_SGIX_framezoom && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glFrameZoomSGIX(GLint factor)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, void> glFrameZoomSGIX;
    }
}
#endif