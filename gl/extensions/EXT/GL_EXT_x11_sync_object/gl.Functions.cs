#if (GL_EXT_x11_sync_object && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLsync glImportSyncEXT(GLenum external_sync_type, GLintptr external_sync, GLbitfield flags);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLintptr, GLbitfield, sync> glImportSyncEXT;
#endif
    }
}
#endif