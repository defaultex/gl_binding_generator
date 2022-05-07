#if (GL_OES_single_precision && (!gl || !gles1))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glClearDepthfOES(GLclampf depth);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLclampf, void> glClearDepthfOES;

        /// <summary>void glClipPlanefOES(GLenum plane, GLfloat* equation);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClipPlaneName, GLfloat*, void> glClipPlanefOES;

        /// <summary>void glDepthRangefOES(GLclampf n, GLclampf f);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLclampf, GLclampf, void> glDepthRangefOES;

        /// <summary>void glFrustumfOES(GLfloat l, GLfloat r, GLfloat b, GLfloat t, GLfloat n, GLfloat f);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glFrustumfOES;

        /// <summary>void glGetClipPlanefOES(GLenum plane, GLfloat* equation);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClipPlaneName, GLfloat*, void> glGetClipPlanefOES;

        /// <summary>void glOrthofOES(GLfloat l, GLfloat r, GLfloat b, GLfloat t, GLfloat n, GLfloat f);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glOrthofOES;
    }
}
#endif