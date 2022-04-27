#if (GL_SGIX_reference_plane && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glReferencePlaneSGIX(const GLdouble* equation)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glReferencePlaneSGIX;
    }
}
#endif