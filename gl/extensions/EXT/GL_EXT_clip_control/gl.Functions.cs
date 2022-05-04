#if (GL_EXT_clip_control && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glClipControlEXT(GLenum origin, GLenum depth);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLenum, void> glClipControlEXT;
#endif
    }
}
#endif