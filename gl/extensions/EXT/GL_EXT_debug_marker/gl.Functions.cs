#if (GL_EXT_debug_marker && (!gl || !glcore || !gles1 || !gles2))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glInsertEventMarkerEXT(GLsizei length, GLchar* marker);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLchar*, void> glInsertEventMarkerEXT;

        /// <summary>void glPopGroupMarkerEXT();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPopGroupMarkerEXT;

        /// <summary>void glPushGroupMarkerEXT(GLsizei length, GLchar* marker);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLchar*, void> glPushGroupMarkerEXT;
    }
}
#endif