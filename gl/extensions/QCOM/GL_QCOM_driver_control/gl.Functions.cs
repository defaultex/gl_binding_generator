#if (GL_QCOM_driver_control && (!gles1 || !gles2))
public partial class gles1 { 
    public partial class Functions { 
        /// <summary>void glDisableDriverControlQCOM(GLuint driverControl);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glDisableDriverControlQCOM;

        /// <summary>void glEnableDriverControlQCOM(GLuint driverControl);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glEnableDriverControlQCOM;

        /// <summary>void glGetDriverControlsQCOM(GLint* num, GLsizei size, GLuint* driverControls);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, GLsizei, GLuint*, void> glGetDriverControlsQCOM;

        /// <summary>void glGetDriverControlStringQCOM(GLuint driverControl, GLsizei bufSize, GLsizei* length, GLchar* driverControlString);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLsizei*, GLchar*, void> glGetDriverControlStringQCOM;
    }
}
#endif