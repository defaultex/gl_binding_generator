#if (GL_EXT_polygon_offset_clamp && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glPolygonOffsetClampEXT(GLfloat factor, GLfloat units, GLfloat clamp);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, void> glPolygonOffsetClampEXT;
    }
}
#endif