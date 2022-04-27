#if (GL_IMG_framebuffer_downsample && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glFramebufferTexture2DDownsampleIMG(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level, GLint xscale, GLint yscale)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, TextureTarget, GLtexture, GLint, GLint, GLint, void> glFramebufferTexture2DDownsampleIMG;

        /// <summary>void glFramebufferTextureLayerDownsampleIMG(GLenum target, GLenum attachment, GLuint texture, GLint level, GLint layer, GLint xscale, GLint yscale)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, GLtexture, GLint, GLint, GLint, GLint, void> glFramebufferTextureLayerDownsampleIMG;
    }
}
#endif