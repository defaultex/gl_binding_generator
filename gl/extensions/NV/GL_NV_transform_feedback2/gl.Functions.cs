#if (GL_NV_transform_feedback2 && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBindTransformFeedbackNV(GLenum target, GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, transformfeedback, void> glBindTransformFeedbackNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDeleteTransformFeedbacksNV(GLsizei n, GLuint* ids);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, transformfeedback*, void> glDeleteTransformFeedbacksNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDrawTransformFeedbackNV(GLenum mode, GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, transformfeedback, void> glDrawTransformFeedbackNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGenTransformFeedbacksNV(GLsizei n, GLuint* ids);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, transformfeedback*, void> glGenTransformFeedbacksNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsTransformFeedbackNV(GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<transformfeedback, GLboolean> glIsTransformFeedbackNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPauseTransformFeedbackNV();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPauseTransformFeedbackNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glResumeTransformFeedbackNV();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glResumeTransformFeedbackNV;
#endif
    }
}
#endif