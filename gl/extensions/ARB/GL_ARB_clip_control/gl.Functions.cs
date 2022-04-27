#if (GL_ARB_clip_control && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glClipControl(GLenum origin, GLenum depth)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClipControlOrigin, ClipControlDepth, void> glClipControl;
    }
}
#endif