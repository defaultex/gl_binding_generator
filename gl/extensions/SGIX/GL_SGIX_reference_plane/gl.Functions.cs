#if (GL_SGIX_reference_plane && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glReferencePlaneSGIX(GLdouble* equation);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glReferencePlaneSGIX;
#endif
    }
}
#endif