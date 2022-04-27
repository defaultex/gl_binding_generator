#if (GL_NV_video_capture && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBeginVideoCaptureNV(GLuint video_capture_slot)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glBeginVideoCaptureNV;

        /// <summary>void glBindVideoCaptureStreamBufferNV(GLuint video_capture_slot, GLuint stream, GLenum frame_region, GLintptrARB offset)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLenum, GLintptrARB, void> glBindVideoCaptureStreamBufferNV;

        /// <summary>void glBindVideoCaptureStreamTextureNV(GLuint video_capture_slot, GLuint stream, GLenum frame_region, GLenum target, GLuint texture)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLenum, GLenum, GLtexture, void> glBindVideoCaptureStreamTextureNV;

        /// <summary>void glEndVideoCaptureNV(GLuint video_capture_slot)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glEndVideoCaptureNV;

        /// <summary>void glGetVideoCaptureStreamdvNV(GLuint video_capture_slot, GLuint stream, GLenum pname, GLdouble* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLenum, GLdouble*, void> glGetVideoCaptureStreamdvNV;

        /// <summary>void glGetVideoCaptureStreamfvNV(GLuint video_capture_slot, GLuint stream, GLenum pname, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLenum, GLfloat*, void> glGetVideoCaptureStreamfvNV;

        /// <summary>void glGetVideoCaptureStreamivNV(GLuint video_capture_slot, GLuint stream, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLenum, GLint*, void> glGetVideoCaptureStreamivNV;

        /// <summary>void glGetVideoCaptureivNV(GLuint video_capture_slot, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLenum, GLint*, void> glGetVideoCaptureivNV;

        /// <summary>GLenum glVideoCaptureNV(GLuint video_capture_slot, GLuint* sequence_num, GLuint64EXT* capture_time)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, GLuint64EXT*, GLenum> glVideoCaptureNV;

        /// <summary>void glVideoCaptureStreamParameterdvNV(GLuint video_capture_slot, GLuint stream, GLenum pname, const GLdouble* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLenum, GLdouble*, void> glVideoCaptureStreamParameterdvNV;

        /// <summary>void glVideoCaptureStreamParameterfvNV(GLuint video_capture_slot, GLuint stream, GLenum pname, const GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLenum, GLfloat*, void> glVideoCaptureStreamParameterfvNV;

        /// <summary>void glVideoCaptureStreamParameterivNV(GLuint video_capture_slot, GLuint stream, GLenum pname, const GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLenum, GLint*, void> glVideoCaptureStreamParameterivNV;
    }
}
#endif