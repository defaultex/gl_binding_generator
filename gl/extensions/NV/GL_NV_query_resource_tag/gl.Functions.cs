#if (GL_NV_query_resource_tag && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDeleteQueryResourceTagNV(GLsizei n, GLint* tagIds);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLint*, void> glDeleteQueryResourceTagNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGenQueryResourceTagNV(GLsizei n, GLint* tagIds);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLint*, void> glGenQueryResourceTagNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glQueryResourceTagNV(GLint tagId, GLchar* tagString);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLchar*, void> glQueryResourceTagNV;
#endif
    }
}
#endif