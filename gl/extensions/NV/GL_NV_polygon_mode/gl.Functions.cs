#if (GL_NV_polygon_mode && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glPolygonModeNV(GLenum face, GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, PolygonMode, void> glPolygonModeNV;
    }
}
#endif