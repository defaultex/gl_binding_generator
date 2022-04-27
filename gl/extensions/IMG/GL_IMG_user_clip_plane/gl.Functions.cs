#if (GL_IMG_user_clip_plane && GLES1_API)
public partial class gles1 { 
    public partial class Functions { 
        /// <summary>void glClipPlanefIMG(GLenum p, const GLfloat* eqn)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClipPlaneName, GLfloat*, void> glClipPlanefIMG;

        /// <summary>void glClipPlanexIMG(GLenum p, const GLfixed* eqn)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClipPlaneName, GLfixed*, void> glClipPlanexIMG;
    }
}
#endif