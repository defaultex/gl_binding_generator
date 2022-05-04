#if (GL_NV_bindless_texture && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLuint64 glGetImageHandleNV(GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum format);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLint, GLboolean, GLint, PixelFormat, GLuint64> glGetImageHandleNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLuint64 glGetTextureHandleNV(GLuint texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLuint64> glGetTextureHandleNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLuint64 glGetTextureSamplerHandleNV(GLuint texture, GLuint sampler);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, sampler, GLuint64> glGetTextureSamplerHandleNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsImageHandleResidentNV(GLuint64 handle);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, GLboolean> glIsImageHandleResidentNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsTextureHandleResidentNV(GLuint64 handle);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, GLboolean> glIsTextureHandleResidentNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMakeImageHandleNonResidentNV(GLuint64 handle);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, void> glMakeImageHandleNonResidentNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMakeImageHandleResidentNV(GLuint64 handle, GLenum access);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, GLenum, void> glMakeImageHandleResidentNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMakeTextureHandleNonResidentNV(GLuint64 handle);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, void> glMakeTextureHandleNonResidentNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMakeTextureHandleResidentNV(GLuint64 handle);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, void> glMakeTextureHandleResidentNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniformHandleui64NV(GLuint program, GLint location, GLuint64 value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLuint64, void> glProgramUniformHandleui64NV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniformHandleui64vNV(GLuint program, GLint location, GLsizei count, GLuint64* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLuint64*, void> glProgramUniformHandleui64vNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniformHandleui64NV(GLint location, GLuint64 value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint64, void> glUniformHandleui64NV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniformHandleui64vNV(GLint location, GLsizei count, GLuint64* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint64*, void> glUniformHandleui64vNV;
#endif
    }
}
#endif