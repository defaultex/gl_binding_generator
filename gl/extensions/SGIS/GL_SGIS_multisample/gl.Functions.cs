#if (GL_SGIS_multisample && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glSampleMaskSGIS(GLclampf value, GLboolean invert)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLclampf, GLboolean, void> glSampleMaskSGIS;

        /// <summary>void glSamplePatternSGIS(GLenum pattern)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<SamplePatternSGIS, void> glSamplePatternSGIS;
    }
}
#endif