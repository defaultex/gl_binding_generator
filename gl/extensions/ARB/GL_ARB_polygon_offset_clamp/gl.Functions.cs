#if (GL_ARB_polygon_offset_clamp && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glPolygonOffsetClamp(GLfloat factor, GLfloat units, GLfloat clamp);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, void> glPolygonOffsetClamp;
    }
}
#endif