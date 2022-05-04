#if (GL_QCOM_driver_control && (GLES1_API || GLES2_API))
public partial class gles1 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDisableDriverControlQCOM(GLuint driverControl);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glDisableDriverControlQCOM;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEnableDriverControlQCOM(GLuint driverControl);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glEnableDriverControlQCOM;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetDriverControlsQCOM(GLint* num, GLsizei size, GLuint* driverControls);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, GLsizei, GLuint*, void> glGetDriverControlsQCOM;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetDriverControlStringQCOM(GLuint driverControl, GLsizei bufSize, GLsizei* length, GLchar* driverControlString);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLsizei*, GLchar*, void> glGetDriverControlStringQCOM;
#endif
    }
}
#endif