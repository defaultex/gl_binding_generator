#if (GL_INTEL_map_texture && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void* glMapTexture2DINTEL(GLuint texture, GLint level, GLbitfield access, GLint* stride, GLenum* layout);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLint, GLbitfield, GLint*, GLenum*, void*> glMapTexture2DINTEL;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSyncTextureINTEL(GLuint texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, void> glSyncTextureINTEL;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUnmapTexture2DINTEL(GLuint texture, GLint level);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLint, void> glUnmapTexture2DINTEL;
#endif
    }
}
#endif