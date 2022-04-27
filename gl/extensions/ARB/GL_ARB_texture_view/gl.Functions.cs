#if (GL_ARB_texture_view && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glTextureView(GLuint texture, GLenum target, GLuint origtexture, GLenum internalformat, GLuint minlevel, GLuint numlevels, GLuint minlayer, GLuint numlayers)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, GLtexture, SizedInternalFormat, GLuint, GLuint, GLuint, GLuint, void> glTextureView;
    }
}
#endif