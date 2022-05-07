#if (GL_ATI_pn_triangles && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glPNTrianglesfATI(GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PNTrianglesPNameATI, GLfloat, void> glPNTrianglesfATI;

        /// <summary>void glPNTrianglesiATI(GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PNTrianglesPNameATI, GLint, void> glPNTrianglesiATI;
    }
}
#endif