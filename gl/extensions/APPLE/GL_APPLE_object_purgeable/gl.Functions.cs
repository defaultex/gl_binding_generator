#if (GL_APPLE_object_purgeable && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glGetObjectParameterivAPPLE(GLenum objectType, GLuint name, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLenum, GLint*, void> glGetObjectParameterivAPPLE;

        /// <summary>GLenum glObjectPurgeableAPPLE(GLenum objectType, GLuint name, GLenum option);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLenum, GLenum> glObjectPurgeableAPPLE;

        /// <summary>GLenum glObjectUnpurgeableAPPLE(GLenum objectType, GLuint name, GLenum option);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLenum, GLenum> glObjectUnpurgeableAPPLE;
    }
}
#endif