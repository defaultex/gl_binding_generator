#if (GL_OES_texture_view && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureViewOES(GLuint texture, GLenum target, GLuint origtexture, GLenum internalformat, GLuint minlevel, GLuint numlevels, GLuint minlayer, GLuint numlayers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, texture, SizedInternalFormat, GLuint, GLuint, GLuint, GLuint, void> glTextureViewOES;
#endif
    }
}
#endif