#if (GL_ATI_pn_triangles && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPNTrianglesfATI(GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PNTrianglesPNameATI, GLfloat, void> glPNTrianglesfATI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPNTrianglesiATI(GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PNTrianglesPNameATI, GLint, void> glPNTrianglesiATI;
#endif
    }
}
#endif