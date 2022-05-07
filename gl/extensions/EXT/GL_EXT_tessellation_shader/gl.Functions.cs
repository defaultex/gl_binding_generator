#if (GL_EXT_tessellation_shader && !gles2)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glPatchParameteriEXT(GLenum pname, GLint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PatchParameterName, GLint, void> glPatchParameteriEXT;
    }
}
#endif