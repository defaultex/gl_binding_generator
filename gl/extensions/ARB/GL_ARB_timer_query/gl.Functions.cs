#if (GL_ARB_timer_query && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetQueryObjecti64v(GLuint id, GLenum pname, GLint64* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<query, QueryObjectParameterName, GLint64*, void> glGetQueryObjecti64v;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetQueryObjectui64v(GLuint id, GLenum pname, GLuint64* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<query, QueryObjectParameterName, GLuint64*, void> glGetQueryObjectui64v;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glQueryCounter(GLuint id, GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<query, QueryCounterTarget, void> glQueryCounter;
#endif
    }
}
#endif