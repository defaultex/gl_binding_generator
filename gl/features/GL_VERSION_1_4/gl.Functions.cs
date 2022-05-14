public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glBlendColor;
        public static unsafe delegate* unmanaged[Cdecl]<BlendEquationMode, void> glBlendEquation;
        public static unsafe delegate* unmanaged[Cdecl]<BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void> glBlendFuncSeparate;
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint*, GLsizei*, GLsizei, void> glMultiDrawArrays;
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei*, ElementType, void**, GLsizei, void> glMultiDrawElements;
        public static unsafe delegate* unmanaged[Cdecl]<PointParameter, GLfloat, void> glPointParameterf;
        public static unsafe delegate* unmanaged[Cdecl]<PointParameter, GLfloat*, void> glPointParameterfv;
        public static unsafe delegate* unmanaged[Cdecl]<PointParameter, GLint, void> glPointParameteri;
        public static unsafe delegate* unmanaged[Cdecl]<PointParameter, GLint*, void> glPointParameteriv;
    }
}
