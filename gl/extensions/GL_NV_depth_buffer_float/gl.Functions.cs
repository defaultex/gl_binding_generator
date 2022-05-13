#if GL_NV_depth_buffer_float

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, void> glClearDepthdNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, void> glDepthBoundsdNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, void> glDepthRangedNV;
    }
}

#endif