#if (GL_NV_explicit_multisample && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetMultisamplefvNV(GLenum pname, GLuint index, GLfloat* val);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetMultisamplePNameNV, GLuint, GLfloat*, void> glGetMultisamplefvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSampleMaskIndexedNV(GLuint index, GLbitfield mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLbitfield, void> glSampleMaskIndexedNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexRenderbufferNV(GLenum target, GLuint renderbuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, renderbuffer, void> glTexRenderbufferNV;
#endif
    }
}
#endif