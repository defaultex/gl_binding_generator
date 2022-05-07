#if (GL_SGIX_reference_plane && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glReferencePlaneSGIX(GLdouble* equation);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glReferencePlaneSGIX;
    }
}
#endif