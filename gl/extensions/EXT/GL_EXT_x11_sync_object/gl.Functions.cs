#if (GL_EXT_x11_sync_object && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>GLsync glImportSyncEXT(GLenum external_sync_type, GLintptr external_sync, GLbitfield flags);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLintptr, GLbitfield, GLsync> glImportSyncEXT;
    }
}
#endif