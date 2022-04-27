#if (GL_SGIX_fragment_lighting && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glFragmentColorMaterialSGIX(GLenum face, GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, void> glFragmentColorMaterialSGIX;

        /// <summary>void glFragmentLightModelfSGIX(GLenum pname, GLfloat param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FragmentLightModelParameterSGIX, GLfloat, void> glFragmentLightModelfSGIX;

        /// <summary>void glFragmentLightModelfvSGIX(GLenum pname, const GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FragmentLightModelParameterSGIX, GLfloat*, void> glFragmentLightModelfvSGIX;

        /// <summary>void glFragmentLightModeliSGIX(GLenum pname, GLint param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FragmentLightModelParameterSGIX, GLint, void> glFragmentLightModeliSGIX;

        /// <summary>void glFragmentLightModelivSGIX(GLenum pname, const GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FragmentLightModelParameterSGIX, GLint*, void> glFragmentLightModelivSGIX;

        /// <summary>void glFragmentLightfSGIX(GLenum light, GLenum pname, GLfloat param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FragmentLightNameSGIX, FragmentLightParameterSGIX, GLfloat, void> glFragmentLightfSGIX;

        /// <summary>void glFragmentLightfvSGIX(GLenum light, GLenum pname, const GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FragmentLightNameSGIX, FragmentLightParameterSGIX, GLfloat*, void> glFragmentLightfvSGIX;

        /// <summary>void glFragmentLightiSGIX(GLenum light, GLenum pname, GLint param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FragmentLightNameSGIX, FragmentLightParameterSGIX, GLint, void> glFragmentLightiSGIX;

        /// <summary>void glFragmentLightivSGIX(GLenum light, GLenum pname, const GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FragmentLightNameSGIX, FragmentLightParameterSGIX, GLint*, void> glFragmentLightivSGIX;

        /// <summary>void glFragmentMaterialfSGIX(GLenum face, GLenum pname, GLfloat param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLfloat, void> glFragmentMaterialfSGIX;

        /// <summary>void glFragmentMaterialfvSGIX(GLenum face, GLenum pname, const GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLfloat*, void> glFragmentMaterialfvSGIX;

        /// <summary>void glFragmentMaterialiSGIX(GLenum face, GLenum pname, GLint param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLint, void> glFragmentMaterialiSGIX;

        /// <summary>void glFragmentMaterialivSGIX(GLenum face, GLenum pname, const GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLint*, void> glFragmentMaterialivSGIX;

        /// <summary>void glGetFragmentLightfvSGIX(GLenum light, GLenum pname, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FragmentLightNameSGIX, FragmentLightParameterSGIX, GLfloat*, void> glGetFragmentLightfvSGIX;

        /// <summary>void glGetFragmentLightivSGIX(GLenum light, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FragmentLightNameSGIX, FragmentLightParameterSGIX, GLint*, void> glGetFragmentLightivSGIX;

        /// <summary>void glGetFragmentMaterialfvSGIX(GLenum face, GLenum pname, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLfloat*, void> glGetFragmentMaterialfvSGIX;

        /// <summary>void glGetFragmentMaterialivSGIX(GLenum face, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLint*, void> glGetFragmentMaterialivSGIX;

        /// <summary>void glLightEnviSGIX(GLenum pname, GLint param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightEnvParameterSGIX, GLint, void> glLightEnviSGIX;
    }
}
#endif