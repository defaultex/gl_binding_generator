#if GL_EXT_debug_marker

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLchar*, void> glInsertEventMarkerEXT;
        public static unsafe delegate* unmanaged[Cdecl]<void> glPopGroupMarkerEXT;
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLchar*, void> glPushGroupMarkerEXT;
    }
}

#endif