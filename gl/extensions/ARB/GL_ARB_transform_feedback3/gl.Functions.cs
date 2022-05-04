#if (GL_ARB_transform_feedback3 && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glBeginQueryIndexed(GLenum target, GLuint index, GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, GLuint, query, void> glBeginQueryIndexed;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glDrawTransformFeedbackStream(GLenum mode, GLuint id, GLuint stream);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, transformfeedback, GLuint, void> glDrawTransformFeedbackStream;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glEndQueryIndexed(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, GLuint, void> glEndQueryIndexed;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetQueryIndexediv(GLenum target, GLuint index, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, GLuint, QueryParameterName, GLint*, void> glGetQueryIndexediv;
#endif
    }
}
#endif