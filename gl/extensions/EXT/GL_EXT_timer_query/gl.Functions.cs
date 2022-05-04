#if (GL_EXT_timer_query && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetQueryObjecti64vEXT(GLuint id, GLenum pname, GLint64* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<query, QueryObjectParameterName, GLint64*, void> glGetQueryObjecti64vEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetQueryObjectui64vEXT(GLuint id, GLenum pname, GLuint64* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<query, QueryObjectParameterName, GLuint64*, void> glGetQueryObjectui64vEXT;
#endif
    }
}
#endif