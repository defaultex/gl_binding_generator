#if (GL_EXT_polygon_offset && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPolygonOffsetEXT(GLfloat factor, GLfloat bias);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glPolygonOffsetEXT;
#endif
    }
}
#endif