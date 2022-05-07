#if (GL_INTEL_map_texture && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void* glMapTexture2DINTEL(GLuint texture, GLint level, GLbitfield access, GLint* stride, GLenum* layout);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, GLbitfield, GLint*, GLenum*, void*> glMapTexture2DINTEL;

        /// <summary>void glSyncTextureINTEL(GLuint texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, void> glSyncTextureINTEL;

        /// <summary>void glUnmapTexture2DINTEL(GLuint texture, GLint level);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, void> glUnmapTexture2DINTEL;
    }
}
#endif