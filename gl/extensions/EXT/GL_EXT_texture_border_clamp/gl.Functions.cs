#if (GL_EXT_texture_border_clamp && !gles2)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glGetSamplerParameterIivEXT(GLuint sampler, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLint*, void> glGetSamplerParameterIivEXT;

        /// <summary>void glGetSamplerParameterIuivEXT(GLuint sampler, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLuint*, void> glGetSamplerParameterIuivEXT;

        /// <summary>void glGetTexParameterIivEXT(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLint*, void> glGetTexParameterIivEXT;

        /// <summary>void glGetTexParameterIuivEXT(GLenum target, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLuint*, void> glGetTexParameterIuivEXT;

        /// <summary>void glSamplerParameterIivEXT(GLuint sampler, GLenum pname, GLint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLint*, void> glSamplerParameterIivEXT;

        /// <summary>void glSamplerParameterIuivEXT(GLuint sampler, GLenum pname, GLuint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLuint*, void> glSamplerParameterIuivEXT;

        /// <summary>void glTexParameterIivEXT(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLint*, void> glTexParameterIivEXT;

        /// <summary>void glTexParameterIuivEXT(GLenum target, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLuint*, void> glTexParameterIuivEXT;
    }
}
#endif