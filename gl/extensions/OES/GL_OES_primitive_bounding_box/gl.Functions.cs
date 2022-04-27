#if (GL_OES_primitive_bounding_box && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glPrimitiveBoundingBoxOES(GLfloat minX, GLfloat minY, GLfloat minZ, GLfloat minW, GLfloat maxX, GLfloat maxY, GLfloat maxZ, GLfloat maxW)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glPrimitiveBoundingBoxOES;
    }
}
#endif