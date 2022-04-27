#if (GL_NV_texture_multisample && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glTexImage2DMultisampleCoverageNV(GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLint internalFormat, GLsizei width, GLsizei height, GLboolean fixedSampleLocations)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, GLsizei, InternalFormat, GLsizei, GLsizei, GLboolean, void> glTexImage2DMultisampleCoverageNV;

        /// <summary>void glTexImage3DMultisampleCoverageNV(GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLint internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedSampleLocations)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, GLsizei, InternalFormat, GLsizei, GLsizei, GLsizei, GLboolean, void> glTexImage3DMultisampleCoverageNV;

        /// <summary>void glTextureImage2DMultisampleCoverageNV(GLuint texture, GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLint internalFormat, GLsizei width, GLsizei height, GLboolean fixedSampleLocations)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, GLsizei, GLsizei, InternalFormat, GLsizei, GLsizei, GLboolean, void> glTextureImage2DMultisampleCoverageNV;

        /// <summary>void glTextureImage2DMultisampleNV(GLuint texture, GLenum target, GLsizei samples, GLint internalFormat, GLsizei width, GLsizei height, GLboolean fixedSampleLocations)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, GLsizei, InternalFormat, GLsizei, GLsizei, GLboolean, void> glTextureImage2DMultisampleNV;

        /// <summary>void glTextureImage3DMultisampleCoverageNV(GLuint texture, GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLint internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedSampleLocations)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, GLsizei, GLsizei, InternalFormat, GLsizei, GLsizei, GLsizei, GLboolean, void> glTextureImage3DMultisampleCoverageNV;

        /// <summary>void glTextureImage3DMultisampleNV(GLuint texture, GLenum target, GLsizei samples, GLint internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedSampleLocations)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, GLsizei, InternalFormat, GLsizei, GLsizei, GLsizei, GLboolean, void> glTextureImage3DMultisampleNV;
    }
}
#endif