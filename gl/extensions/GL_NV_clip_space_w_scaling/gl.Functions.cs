#if GL_NV_clip_space_w_scaling

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, void> glViewportPositionWScaleNV;
    }
}

#endif