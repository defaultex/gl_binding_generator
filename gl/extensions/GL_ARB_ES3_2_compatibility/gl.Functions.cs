#if GL_ARB_ES3_2_compatibility

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glPrimitiveBoundingBoxARB;
    }
}

#endif