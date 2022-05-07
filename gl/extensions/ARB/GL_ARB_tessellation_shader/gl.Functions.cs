#if (GL_ARB_tessellation_shader && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glPatchParameterfv(GLenum pname, GLfloat* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PatchParameterName, GLfloat*, void> glPatchParameterfv;

        /// <summary>void glPatchParameteri(GLenum pname, GLint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PatchParameterName, GLint, void> glPatchParameteri;
    }
}
#endif