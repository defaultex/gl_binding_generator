#if (GL_NV_present_video && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetVideoi64vNV(GLuint video_slot, GLenum pname, GLint64EXT* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLenum, GLint64EXT*, void> glGetVideoi64vNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetVideoivNV(GLuint video_slot, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLenum, GLint*, void> glGetVideoivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetVideoui64vNV(GLuint video_slot, GLenum pname, GLuint64EXT* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLenum, GLuint64EXT*, void> glGetVideoui64vNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetVideouivNV(GLuint video_slot, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLenum, GLuint*, void> glGetVideouivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPresentFrameDualFillNV(GLuint video_slot, GLuint64EXT minPresentTime, GLuint beginPresentTimeId, GLuint presentDurationId, GLenum type, GLenum target0, GLuint fill0, GLenum target1, GLuint fill1, GLenum target2, GLuint fill2, GLenum target3, GLuint fill3);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint64EXT, GLuint, GLuint, GLenum, GLenum, GLuint, GLenum, GLuint, GLenum, GLuint, GLenum, GLuint, void> glPresentFrameDualFillNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPresentFrameKeyedNV(GLuint video_slot, GLuint64EXT minPresentTime, GLuint beginPresentTimeId, GLuint presentDurationId, GLenum type, GLenum target0, GLuint fill0, GLuint key0, GLenum target1, GLuint fill1, GLuint key1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint64EXT, GLuint, GLuint, GLenum, GLenum, GLuint, GLuint, GLenum, GLuint, GLuint, void> glPresentFrameKeyedNV;
#endif
    }
}
#endif