#if (GL_EXT_texture_border_clamp && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetSamplerParameterIivEXT(GLuint sampler, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterI, GLint*, void> glGetSamplerParameterIivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetSamplerParameterIuivEXT(GLuint sampler, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterI, GLuint*, void> glGetSamplerParameterIuivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetTexParameterIivEXT(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLint*, void> glGetTexParameterIivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetTexParameterIuivEXT(GLenum target, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLuint*, void> glGetTexParameterIuivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSamplerParameterIivEXT(GLuint sampler, GLenum pname, GLint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterI, GLint*, void> glSamplerParameterIivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSamplerParameterIuivEXT(GLuint sampler, GLenum pname, GLuint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterI, GLuint*, void> glSamplerParameterIuivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexParameterIivEXT(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLint*, void> glTexParameterIivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexParameterIuivEXT(GLenum target, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLuint*, void> glTexParameterIuivEXT;
#endif
    }
}
#endif