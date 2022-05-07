#if (GL_QCOM_texture_foveated && !gles2)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glTextureFoveationParametersQCOM(GLuint texture, GLuint layer, GLuint focalPoint, GLfloat focalX, GLfloat focalY, GLfloat gainX, GLfloat gainY, GLfloat foveaArea);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLuint, GLuint, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glTextureFoveationParametersQCOM;
    }
}
#endif