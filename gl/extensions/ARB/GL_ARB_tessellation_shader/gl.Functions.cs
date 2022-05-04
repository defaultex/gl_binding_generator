#if (GL_ARB_tessellation_shader && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glPatchParameterfv(GLenum pname, GLfloat* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PatchParameterName, GLfloat*, void> glPatchParameterfv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glPatchParameteri(GLenum pname, GLint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PatchParameterName, GLint, void> glPatchParameteri;
#endif
    }
}
#endif