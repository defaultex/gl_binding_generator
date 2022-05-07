#if (GL_ARB_multisample && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glSampleCoverageARB(GLfloat value, GLboolean invert);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLboolean, void> glSampleCoverageARB;
    }
}
#endif