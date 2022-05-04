#if (GL_SGIX_fragment_lighting && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFragmentColorMaterialSGIX(GLenum face, GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, void> glFragmentColorMaterialSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFragmentLightfSGIX(GLenum light, GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FragmentLightNameSGIX, FragmentLightParameterSGIX, GLfloat, void> glFragmentLightfSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFragmentLightfvSGIX(GLenum light, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FragmentLightNameSGIX, FragmentLightParameterSGIX, GLfloat*, void> glFragmentLightfvSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFragmentLightiSGIX(GLenum light, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FragmentLightNameSGIX, FragmentLightParameterSGIX, GLint, void> glFragmentLightiSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFragmentLightivSGIX(GLenum light, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FragmentLightNameSGIX, FragmentLightParameterSGIX, GLint*, void> glFragmentLightivSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFragmentLightModelfSGIX(GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FragmentLightModelParameterSGIX, GLfloat, void> glFragmentLightModelfSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFragmentLightModelfvSGIX(GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FragmentLightModelParameterSGIX, GLfloat*, void> glFragmentLightModelfvSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFragmentLightModeliSGIX(GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FragmentLightModelParameterSGIX, GLint, void> glFragmentLightModeliSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFragmentLightModelivSGIX(GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FragmentLightModelParameterSGIX, GLint*, void> glFragmentLightModelivSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFragmentMaterialfSGIX(GLenum face, GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLfloat, void> glFragmentMaterialfSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFragmentMaterialfvSGIX(GLenum face, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLfloat*, void> glFragmentMaterialfvSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFragmentMaterialiSGIX(GLenum face, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLint, void> glFragmentMaterialiSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFragmentMaterialivSGIX(GLenum face, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLint*, void> glFragmentMaterialivSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetFragmentLightfvSGIX(GLenum light, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FragmentLightNameSGIX, FragmentLightParameterSGIX, GLfloat*, void> glGetFragmentLightfvSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetFragmentLightivSGIX(GLenum light, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FragmentLightNameSGIX, FragmentLightParameterSGIX, GLint*, void> glGetFragmentLightivSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetFragmentMaterialfvSGIX(GLenum face, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLfloat*, void> glGetFragmentMaterialfvSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetFragmentMaterialivSGIX(GLenum face, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLint*, void> glGetFragmentMaterialivSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glLightEnviSGIX(GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightEnvParameterSGIX, GLint, void> glLightEnviSGIX;
#endif
    }
}
#endif