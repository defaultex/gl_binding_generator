#if (GL_QCOM_shading_rate && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glShadingRateQCOM(GLenum rate)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShadingRateQCOM, void> glShadingRateQCOM;
    }
}
#endif