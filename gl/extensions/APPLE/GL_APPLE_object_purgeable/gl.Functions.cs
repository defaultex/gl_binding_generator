#if (GL_APPLE_object_purgeable && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetObjectParameterivAPPLE(GLenum objectType, GLuint name, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLenum, GLint*, void> glGetObjectParameterivAPPLE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLenum glObjectPurgeableAPPLE(GLenum objectType, GLuint name, GLenum option);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLenum, GLenum> glObjectPurgeableAPPLE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLenum glObjectUnpurgeableAPPLE(GLenum objectType, GLuint name, GLenum option);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLenum, GLenum> glObjectUnpurgeableAPPLE;
#endif
    }
}
#endif