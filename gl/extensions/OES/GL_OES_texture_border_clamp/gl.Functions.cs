#if (GL_OES_texture_border_clamp && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glGetSamplerParameterIivOES(GLuint sampler, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLint*, void> glGetSamplerParameterIivOES;

        /// <summary>void glGetSamplerParameterIuivOES(GLuint sampler, GLenum pname, GLuint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLuint*, void> glGetSamplerParameterIuivOES;

        /// <summary>void glGetTexParameterIivOES(GLenum target, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLint*, void> glGetTexParameterIivOES;

        /// <summary>void glGetTexParameterIuivOES(GLenum target, GLenum pname, GLuint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLuint*, void> glGetTexParameterIuivOES;

        /// <summary>void glSamplerParameterIivOES(GLuint sampler, GLenum pname, const GLint* param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLint*, void> glSamplerParameterIivOES;

        /// <summary>void glSamplerParameterIuivOES(GLuint sampler, GLenum pname, const GLuint* param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLuint*, void> glSamplerParameterIuivOES;

        /// <summary>void glTexParameterIivOES(GLenum target, GLenum pname, const GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLint*, void> glTexParameterIivOES;

        /// <summary>void glTexParameterIuivOES(GLenum target, GLenum pname, const GLuint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLuint*, void> glTexParameterIuivOES;
    }
}
#endif