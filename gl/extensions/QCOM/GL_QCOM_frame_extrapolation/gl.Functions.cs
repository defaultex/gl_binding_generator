#if (GL_QCOM_frame_extrapolation && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glExtrapolateTex2DQCOM(GLuint src1, GLuint src2, GLuint output, GLfloat scaleFactor)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLtexture, GLtexture, GLfloat, void> glExtrapolateTex2DQCOM;
    }
}
#endif