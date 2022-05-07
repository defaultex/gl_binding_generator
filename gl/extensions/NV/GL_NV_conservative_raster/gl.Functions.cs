#if (GL_NV_conservative_raster && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glSubpixelPrecisionBiasNV(GLuint xbits, GLuint ybits);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glSubpixelPrecisionBiasNV;
    }
}
#endif