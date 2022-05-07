#if (GL_EXT_primitive_bounding_box && !gles2)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glPrimitiveBoundingBoxEXT(GLfloat minX, GLfloat minY, GLfloat minZ, GLfloat minW, GLfloat maxX, GLfloat maxY, GLfloat maxZ, GLfloat maxW);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glPrimitiveBoundingBoxEXT;
    }
}
#endif