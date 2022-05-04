#if (GL_AMD_sample_positions && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSetMultisamplefvAMD(GLenum pname, GLuint index, GLfloat* val);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLfloat*, void> glSetMultisamplefvAMD;
#endif
    }
}
#endif