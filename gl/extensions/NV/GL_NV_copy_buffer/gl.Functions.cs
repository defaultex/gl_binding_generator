#if (GL_NV_copy_buffer && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCopyBufferSubDataNV(GLenum readTarget, GLenum writeTarget, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CopyBufferSubDataTarget, CopyBufferSubDataTarget, GLintptr, GLintptr, GLsizeiptr, void> glCopyBufferSubDataNV;
#endif
    }
}
#endif