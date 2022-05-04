#if (GL_EXT_debug_marker && (GL_API || GLCORE_API || GLES1_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glInsertEventMarkerEXT(GLsizei length, GLchar* marker);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLchar*, void> glInsertEventMarkerEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPopGroupMarkerEXT();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPopGroupMarkerEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPushGroupMarkerEXT(GLsizei length, GLchar* marker);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLchar*, void> glPushGroupMarkerEXT;
#endif
    }
}
#endif