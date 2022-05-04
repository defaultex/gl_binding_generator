#if (GL_IMG_user_clip_plane && GLES1_API)
public partial class gles1 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glClipPlanefIMG(GLenum p, GLfloat* eqn);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClipPlaneName, GLfloat*, void> glClipPlanefIMG;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glClipPlanexIMG(GLenum p, GLfixed* eqn);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClipPlaneName, GLfixed*, void> glClipPlanexIMG;
#endif
    }
}
#endif