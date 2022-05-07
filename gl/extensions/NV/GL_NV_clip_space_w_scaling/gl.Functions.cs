#if (GL_NV_clip_space_w_scaling && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glViewportPositionWScaleNV(GLuint index, GLfloat xcoeff, GLfloat ycoeff);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, void> glViewportPositionWScaleNV;
    }
}
#endif