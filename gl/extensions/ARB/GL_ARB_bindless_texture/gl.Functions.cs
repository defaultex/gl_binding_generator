#if (GL_ARB_bindless_texture && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLuint64 glGetImageHandleARB(GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum format);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLint, GLboolean, GLint, PixelFormat, GLuint64> glGetImageHandleARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLuint64 glGetTextureHandleARB(GLuint texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLuint64> glGetTextureHandleARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLuint64 glGetTextureSamplerHandleARB(GLuint texture, GLuint sampler);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, sampler, GLuint64> glGetTextureSamplerHandleARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetVertexAttribLui64vARB(GLuint index, GLenum pname, GLuint64EXT* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribEnum, GLuint64EXT*, void> glGetVertexAttribLui64vARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsImageHandleResidentARB(GLuint64 handle);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, GLboolean> glIsImageHandleResidentARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsTextureHandleResidentARB(GLuint64 handle);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, GLboolean> glIsTextureHandleResidentARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMakeImageHandleNonResidentARB(GLuint64 handle);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, void> glMakeImageHandleNonResidentARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMakeImageHandleResidentARB(GLuint64 handle, GLenum access);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, GLenum, void> glMakeImageHandleResidentARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMakeTextureHandleNonResidentARB(GLuint64 handle);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, void> glMakeTextureHandleNonResidentARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMakeTextureHandleResidentARB(GLuint64 handle);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, void> glMakeTextureHandleResidentARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniformHandleui64ARB(GLuint program, GLint location, GLuint64 value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLuint64, void> glProgramUniformHandleui64ARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniformHandleui64vARB(GLuint program, GLint location, GLsizei count, GLuint64* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLuint64*, void> glProgramUniformHandleui64vARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniformHandleui64ARB(GLint location, GLuint64 value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint64, void> glUniformHandleui64ARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniformHandleui64vARB(GLint location, GLsizei count, GLuint64* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint64*, void> glUniformHandleui64vARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribL1ui64ARB(GLuint index, GLuint64EXT x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint64EXT, void> glVertexAttribL1ui64ARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribL1ui64vARB(GLuint index, GLuint64EXT* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint64EXT*, void> glVertexAttribL1ui64vARB;
#endif
    }
}
#endif