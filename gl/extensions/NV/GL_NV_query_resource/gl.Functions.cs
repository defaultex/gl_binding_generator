#if (GL_NV_query_resource && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLint glQueryResourceNV(GLenum queryType, GLint tagId, GLuint count, GLint* buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLint, GLuint, GLint*, GLint> glQueryResourceNV;
#endif
    }
}
#endif