#if (GL_OES_single_precision && (GL_API || GLES1_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glClearDepthfOES(GLclampf depth);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLclampf, void> glClearDepthfOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glClipPlanefOES(GLenum plane, GLfloat* equation);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClipPlaneName, GLfloat*, void> glClipPlanefOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDepthRangefOES(GLclampf n, GLclampf f);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLclampf, GLclampf, void> glDepthRangefOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFrustumfOES(GLfloat l, GLfloat r, GLfloat b, GLfloat t, GLfloat n, GLfloat f);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glFrustumfOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetClipPlanefOES(GLenum plane, GLfloat* equation);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClipPlaneName, GLfloat*, void> glGetClipPlanefOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glOrthofOES(GLfloat l, GLfloat r, GLfloat b, GLfloat t, GLfloat n, GLfloat f);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glOrthofOES;
#endif
    }
}
#endif