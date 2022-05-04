#if (GL_NV_video_capture && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBeginVideoCaptureNV(GLuint video_capture_slot);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glBeginVideoCaptureNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBindVideoCaptureStreamBufferNV(GLuint video_capture_slot, GLuint stream, GLenum frame_region, GLintptrARB offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLenum, GLintptrARB, void> glBindVideoCaptureStreamBufferNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBindVideoCaptureStreamTextureNV(GLuint video_capture_slot, GLuint stream, GLenum frame_region, GLenum target, GLuint texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLenum, GLenum, texture, void> glBindVideoCaptureStreamTextureNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEndVideoCaptureNV(GLuint video_capture_slot);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glEndVideoCaptureNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetVideoCaptureivNV(GLuint video_capture_slot, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLenum, GLint*, void> glGetVideoCaptureivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetVideoCaptureStreamdvNV(GLuint video_capture_slot, GLuint stream, GLenum pname, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLenum, GLdouble*, void> glGetVideoCaptureStreamdvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetVideoCaptureStreamfvNV(GLuint video_capture_slot, GLuint stream, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLenum, GLfloat*, void> glGetVideoCaptureStreamfvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetVideoCaptureStreamivNV(GLuint video_capture_slot, GLuint stream, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLenum, GLint*, void> glGetVideoCaptureStreamivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLenum glVideoCaptureNV(GLuint video_capture_slot, GLuint* sequence_num, GLuint64EXT* capture_time);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, GLuint64EXT*, GLenum> glVideoCaptureNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVideoCaptureStreamParameterdvNV(GLuint video_capture_slot, GLuint stream, GLenum pname, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLenum, GLdouble*, void> glVideoCaptureStreamParameterdvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVideoCaptureStreamParameterfvNV(GLuint video_capture_slot, GLuint stream, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLenum, GLfloat*, void> glVideoCaptureStreamParameterfvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVideoCaptureStreamParameterivNV(GLuint video_capture_slot, GLuint stream, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLenum, GLint*, void> glVideoCaptureStreamParameterivNV;
#endif
    }
}
#endif