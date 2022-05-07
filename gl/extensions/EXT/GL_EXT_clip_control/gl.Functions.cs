#if (GL_EXT_clip_control && !gles2)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glClipControlEXT(GLenum origin, GLenum depth);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLenum, void> glClipControlEXT;
    }
}
#endif