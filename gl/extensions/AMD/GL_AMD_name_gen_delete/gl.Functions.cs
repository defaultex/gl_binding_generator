#if (GL_AMD_name_gen_delete && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDeleteNamesAMD(GLenum identifier, GLuint num, GLuint* names);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLuint*, void> glDeleteNamesAMD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGenNamesAMD(GLenum identifier, GLuint num, GLuint* names);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLuint*, void> glGenNamesAMD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsNameAMD(GLenum identifier, GLuint name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLboolean> glIsNameAMD;
#endif
    }
}
#endif