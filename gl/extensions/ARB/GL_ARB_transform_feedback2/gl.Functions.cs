#if (GL_ARB_transform_feedback2 && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glBindTransformFeedback(GLenum target, GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BindTransformFeedbackTarget, transformfeedback, void> glBindTransformFeedback;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glDeleteTransformFeedbacks(GLsizei n, GLuint* ids);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, transformfeedback*, void> glDeleteTransformFeedbacks;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glDrawTransformFeedback(GLenum mode, GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, transformfeedback, void> glDrawTransformFeedback;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGenTransformFeedbacks(GLsizei n, GLuint* ids);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, transformfeedback*, void> glGenTransformFeedbacks;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>GLboolean glIsTransformFeedback(GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<transformfeedback, GLboolean> glIsTransformFeedback;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glPauseTransformFeedback();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPauseTransformFeedback;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glResumeTransformFeedback();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glResumeTransformFeedback;
#endif
    }
}
#endif