#if (GL_QCOM_texture_foveated && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureFoveationParametersQCOM(GLuint texture, GLuint layer, GLuint focalPoint, GLfloat focalX, GLfloat focalY, GLfloat gainX, GLfloat gainY, GLfloat foveaArea);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLuint, GLuint, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glTextureFoveationParametersQCOM;
#endif
    }
}
#endif