#if (GL_EXT_draw_transform_feedback && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDrawTransformFeedbackEXT(GLenum mode, GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, transformfeedback, void> glDrawTransformFeedbackEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDrawTransformFeedbackInstancedEXT(GLenum mode, GLuint id, GLsizei instancecount);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, transformfeedback, GLsizei, void> glDrawTransformFeedbackInstancedEXT;
#endif
    }
}
#endif