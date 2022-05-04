#if (GL_OES_texture_border_clamp && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetSamplerParameterIivOES(GLuint sampler, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterI, GLint*, void> glGetSamplerParameterIivOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetSamplerParameterIuivOES(GLuint sampler, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterI, GLuint*, void> glGetSamplerParameterIuivOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetTexParameterIivOES(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLint*, void> glGetTexParameterIivOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetTexParameterIuivOES(GLenum target, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLuint*, void> glGetTexParameterIuivOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSamplerParameterIivOES(GLuint sampler, GLenum pname, GLint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterI, GLint*, void> glSamplerParameterIivOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSamplerParameterIuivOES(GLuint sampler, GLenum pname, GLuint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterI, GLuint*, void> glSamplerParameterIuivOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexParameterIivOES(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLint*, void> glTexParameterIivOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexParameterIuivOES(GLenum target, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLuint*, void> glTexParameterIuivOES;
#endif
    }
}
#endif