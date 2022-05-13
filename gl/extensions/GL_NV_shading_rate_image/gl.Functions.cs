#if GL_NV_shading_rate_image

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, void> glBindShadingRateImageNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLenum*, void> glGetShadingRateImagePaletteNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLuint, GLint*, void> glGetShadingRateSampleLocationivNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLboolean, void> glShadingRateImageBarrierNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLsizei, GLenum*, void> glShadingRateImagePaletteNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLint*, void> glShadingRateSampleOrderCustomNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, void> glShadingRateSampleOrderNV;
    }
}

#endif