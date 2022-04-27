#if (GL_IBM_static_data && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glFlushStaticDataIBM(GLenum target)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, void> glFlushStaticDataIBM;
    }
}
#endif