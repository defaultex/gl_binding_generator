#if GL_ARB_sample_shading

public partial class gl { 
    public partial class Functions { 

        /// <summary>void glMinSampleShadingARB(GLfloat value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glMinSampleShadingARB;
    }
}

#endif