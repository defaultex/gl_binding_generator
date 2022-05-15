#if GL_NV_shading_rate_image

public partial class gl { 
    public partial class Functions { 

        /// <summary>void glBindShadingRateImageNV(GLuint texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, void> glBindShadingRateImageNV;

        /// <summary>void glGetShadingRateImagePaletteNV(GLuint viewport, GLuint entry, GLenum* rate);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLenum*, void> glGetShadingRateImagePaletteNV;

        /// <summary>void glGetShadingRateSampleLocationivNV(GLenum rate, GLuint samples, GLuint index, GLint* location);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLuint, GLint*, void> glGetShadingRateSampleLocationivNV;

        /// <summary>void glShadingRateImageBarrierNV(GLboolean synchronize);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLboolean, void> glShadingRateImageBarrierNV;

        /// <summary>void glShadingRateImagePaletteNV(GLuint viewport, GLuint first, GLsizei count, GLenum* rates);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLsizei, GLenum*, void> glShadingRateImagePaletteNV;

        /// <summary>void glShadingRateSampleOrderCustomNV(GLenum rate, GLuint samples, GLint* locations);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLint*, void> glShadingRateSampleOrderCustomNV;

        /// <summary>void glShadingRateSampleOrderNV(GLenum order);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, void> glShadingRateSampleOrderNV;
    }
}

#endif