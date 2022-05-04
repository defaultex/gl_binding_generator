#if (GL_NV_texture_multisample && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexImage2DMultisampleCoverageNV(GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLint internalFormat, GLsizei width, GLsizei height, GLboolean fixedSampleLocations);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, GLsizei, InternalFormat, GLsizei, GLsizei, GLboolean, void> glTexImage2DMultisampleCoverageNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexImage3DMultisampleCoverageNV(GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLint internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedSampleLocations);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, GLsizei, InternalFormat, GLsizei, GLsizei, GLsizei, GLboolean, void> glTexImage3DMultisampleCoverageNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureImage2DMultisampleCoverageNV(GLuint texture, GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLint internalFormat, GLsizei width, GLsizei height, GLboolean fixedSampleLocations);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, GLsizei, GLsizei, InternalFormat, GLsizei, GLsizei, GLboolean, void> glTextureImage2DMultisampleCoverageNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureImage2DMultisampleNV(GLuint texture, GLenum target, GLsizei samples, GLint internalFormat, GLsizei width, GLsizei height, GLboolean fixedSampleLocations);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, GLsizei, InternalFormat, GLsizei, GLsizei, GLboolean, void> glTextureImage2DMultisampleNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureImage3DMultisampleCoverageNV(GLuint texture, GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLint internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedSampleLocations);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, GLsizei, GLsizei, InternalFormat, GLsizei, GLsizei, GLsizei, GLboolean, void> glTextureImage3DMultisampleCoverageNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureImage3DMultisampleNV(GLuint texture, GLenum target, GLsizei samples, GLint internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedSampleLocations);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, GLsizei, InternalFormat, GLsizei, GLsizei, GLsizei, GLboolean, void> glTextureImage3DMultisampleNV;
#endif
    }
}
#endif