#if (GL_OES_sample_shading && !gles2)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glMinSampleShadingOES(GLfloat value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glMinSampleShadingOES;
    }
}
#endif