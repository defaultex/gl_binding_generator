#if (GL_NV_read_buffer && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glReadBufferNV(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, void> glReadBufferNV;
#endif
    }
}
#endif