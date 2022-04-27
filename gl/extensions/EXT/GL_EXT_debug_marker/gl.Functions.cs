#if (GL_EXT_debug_marker && (GL_API || GLCORE_API || GLES1_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glInsertEventMarkerEXT(GLsizei length, const GLchar* marker)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLchar*, void> glInsertEventMarkerEXT;

        /// <summary>void glPopGroupMarkerEXT()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPopGroupMarkerEXT;

        /// <summary>void glPushGroupMarkerEXT(GLsizei length, const GLchar* marker)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLchar*, void> glPushGroupMarkerEXT;
    }
}
#endif