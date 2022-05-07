#if (GL_EXT_texture_object && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>GLboolean glAreTexturesResidentEXT(GLsizei n, GLuint* textures, GLboolean* residences);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLtexture*, GLboolean*, GLboolean> glAreTexturesResidentEXT;

        /// <summary>void glBindTextureEXT(GLenum target, GLuint texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLtexture, void> glBindTextureEXT;

        /// <summary>void glDeleteTexturesEXT(GLsizei n, GLuint* textures);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLtexture*, void> glDeleteTexturesEXT;

        /// <summary>void glGenTexturesEXT(GLsizei n, GLuint* textures);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLtexture*, void> glGenTexturesEXT;

        /// <summary>GLboolean glIsTextureEXT(GLuint texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLboolean> glIsTextureEXT;

        /// <summary>void glPrioritizeTexturesEXT(GLsizei n, GLuint* textures, GLclampf* priorities);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLtexture*, GLclampf*, void> glPrioritizeTexturesEXT;
    }
}
#endif