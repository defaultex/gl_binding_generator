#if (GL_AMD_occlusion_query_event && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glQueryObjectParameteruiAMD(GLenum target, GLuint id, GLenum pname, GLuint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, GLquery, GLenum, OcclusionQueryEventMaskAMD, void> glQueryObjectParameteruiAMD;
    }
}
#endif