#if (GL_AMD_occlusion_query_event && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glQueryObjectParameteruiAMD(GLenum target, GLuint id, GLenum pname, GLuint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, query, GLenum, OcclusionQueryEventMaskAMD, void> glQueryObjectParameteruiAMD;
#endif
    }
}
#endif