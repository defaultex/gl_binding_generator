#if (GL_ARB_tessellation_shader && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glPatchParameterfv(GLenum pname, const GLfloat* values)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PatchParameterName, GLfloat*, void> glPatchParameterfv;

        /// <summary>void glPatchParameteri(GLenum pname, GLint value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PatchParameterName, GLint, void> glPatchParameteri;
    }
}
#endif