#if (GL_OES_tessellation_shader && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPatchParameteriOES(GLenum pname, GLint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PatchParameterName, GLint, void> glPatchParameteriOES;
#endif
    }
}
#endif