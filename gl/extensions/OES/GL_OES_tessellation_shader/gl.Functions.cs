#if (GL_OES_tessellation_shader && !gles2)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glPatchParameteriOES(GLenum pname, GLint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PatchParameterName, GLint, void> glPatchParameteriOES;
    }
}
#endif