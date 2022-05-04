#if (GL_SGIX_framezoom && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFrameZoomSGIX(GLint factor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, void> glFrameZoomSGIX;
#endif
    }
}
#endif