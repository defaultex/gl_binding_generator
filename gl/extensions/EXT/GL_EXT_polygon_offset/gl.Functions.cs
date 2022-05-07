#if (GL_EXT_polygon_offset && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glPolygonOffsetEXT(GLfloat factor, GLfloat bias);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glPolygonOffsetEXT;
    }
}
#endif