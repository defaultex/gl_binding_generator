#if (GL_ARB_texture_view && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glTextureView(GLuint texture, GLenum target, GLuint origtexture, GLenum internalformat, GLuint minlevel, GLuint numlevels, GLuint minlayer, GLuint numlayers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, texture, SizedInternalFormat, GLuint, GLuint, GLuint, GLuint, void> glTextureView;
#endif
    }
}
#endif