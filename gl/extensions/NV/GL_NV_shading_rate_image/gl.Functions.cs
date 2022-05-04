#if (GL_NV_shading_rate_image && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBindShadingRateImageNV(GLuint texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, void> glBindShadingRateImageNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetShadingRateImagePaletteNV(GLuint viewport, GLuint entry, GLenum* rate);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLenum*, void> glGetShadingRateImagePaletteNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetShadingRateSampleLocationivNV(GLenum rate, GLuint samples, GLuint index, GLint* location);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLuint, GLint*, void> glGetShadingRateSampleLocationivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glShadingRateImageBarrierNV(GLboolean synchronize);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLboolean, void> glShadingRateImageBarrierNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glShadingRateImagePaletteNV(GLuint viewport, GLuint first, GLsizei count, GLenum* rates);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLsizei, GLenum*, void> glShadingRateImagePaletteNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glShadingRateSampleOrderCustomNV(GLenum rate, GLuint samples, GLint* locations);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLint*, void> glShadingRateSampleOrderCustomNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glShadingRateSampleOrderNV(GLenum order);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, void> glShadingRateSampleOrderNV;
#endif
    }
}
#endif