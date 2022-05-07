#if (GL_NV_explicit_multisample && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glGetMultisamplefvNV(GLenum pname, GLuint index, GLfloat* val);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetMultisamplePNameNV, GLuint, GLfloat*, void> glGetMultisamplefvNV;

        /// <summary>void glSampleMaskIndexedNV(GLuint index, GLbitfield mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLbitfield, void> glSampleMaskIndexedNV;

        /// <summary>void glTexRenderbufferNV(GLenum target, GLuint renderbuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLrenderbuffer, void> glTexRenderbufferNV;
    }
}
#endif