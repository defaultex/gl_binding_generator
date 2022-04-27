#if (GL_EXT_texture_view && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glTextureViewEXT(GLuint texture, GLenum target, GLuint origtexture, GLenum internalformat, GLuint minlevel, GLuint numlevels, GLuint minlayer, GLuint numlayers)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, GLtexture, SizedInternalFormat, GLuint, GLuint, GLuint, GLuint, void> glTextureViewEXT;
    }
}
#endif