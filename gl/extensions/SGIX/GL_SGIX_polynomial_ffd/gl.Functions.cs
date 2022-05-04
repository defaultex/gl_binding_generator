#if (GL_SGIX_polynomial_ffd && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDeformationMap3dSGIX(GLenum target, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, GLdouble w1, GLdouble w2, GLint wstride, GLint worder, GLdouble* points);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FfdTargetSGIX, GLdouble, GLdouble, GLint, GLint, GLdouble, GLdouble, GLint, GLint, GLdouble, GLdouble, GLint, GLint, GLdouble*, void> glDeformationMap3dSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDeformationMap3fSGIX(GLenum target, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, GLfloat w1, GLfloat w2, GLint wstride, GLint worder, GLfloat* points);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FfdTargetSGIX, GLfloat, GLfloat, GLint, GLint, GLfloat, GLfloat, GLint, GLint, GLfloat, GLfloat, GLint, GLint, GLfloat*, void> glDeformationMap3fSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDeformSGIX(GLbitfield mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FfdMaskSGIX, void> glDeformSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glLoadIdentityDeformationMapSGIX(GLbitfield mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FfdMaskSGIX, void> glLoadIdentityDeformationMapSGIX;
#endif
    }
}
#endif