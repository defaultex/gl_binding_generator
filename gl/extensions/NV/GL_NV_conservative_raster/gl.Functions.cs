#if (GL_NV_conservative_raster && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSubpixelPrecisionBiasNV(GLuint xbits, GLuint ybits);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glSubpixelPrecisionBiasNV;
#endif
    }
}
#endif