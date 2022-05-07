#if (GL_SGIX_async && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glAsyncMarkerSGIX(GLuint marker);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glAsyncMarkerSGIX;

        /// <summary>void glDeleteAsyncMarkersSGIX(GLuint marker, GLsizei range);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, void> glDeleteAsyncMarkersSGIX;

        /// <summary>GLint glFinishAsyncSGIX(GLuint* markerp);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint*, GLint> glFinishAsyncSGIX;

        /// <summary>GLuint glGenAsyncMarkersSGIX(GLsizei range);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint> glGenAsyncMarkersSGIX;

        /// <summary>GLboolean glIsAsyncMarkerSGIX(GLuint marker);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean> glIsAsyncMarkerSGIX;

        /// <summary>GLint glPollAsyncSGIX(GLuint* markerp);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint*, GLint> glPollAsyncSGIX;
    }
}
#endif