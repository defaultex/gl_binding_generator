#if (GL_EXT_texture_object && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glAreTexturesResidentEXT(GLsizei n, GLuint* textures, GLboolean* residences);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, texture*, GLboolean*, GLboolean> glAreTexturesResidentEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBindTextureEXT(GLenum target, GLuint texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, texture, void> glBindTextureEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDeleteTexturesEXT(GLsizei n, GLuint* textures);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, texture*, void> glDeleteTexturesEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGenTexturesEXT(GLsizei n, GLuint* textures);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, texture*, void> glGenTexturesEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsTextureEXT(GLuint texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLboolean> glIsTextureEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPrioritizeTexturesEXT(GLsizei n, GLuint* textures, GLclampf* priorities);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, texture*, GLclampf*, void> glPrioritizeTexturesEXT;
#endif
    }
}
#endif