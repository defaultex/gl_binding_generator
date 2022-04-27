#if (GL_NV_vdpau_interop && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glVDPAUFiniNV()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glVDPAUFiniNV;

        /// <summary>void glVDPAUGetSurfaceivNV(GLvdpauSurfaceNV surface, GLenum pname, GLsizei count, GLsizei* length, GLint* values)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvdpauSurfaceNV, GLenum, GLsizei, GLsizei*, GLint*, void> glVDPAUGetSurfaceivNV;

        /// <summary>void glVDPAUInitNV(const void* vdpDevice, const void* getProcAddress)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void*, void*, void> glVDPAUInitNV;

        /// <summary>GLboolean glVDPAUIsSurfaceNV(GLvdpauSurfaceNV surface)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvdpauSurfaceNV, GLboolean> glVDPAUIsSurfaceNV;

        /// <summary>void glVDPAUMapSurfacesNV(GLsizei numSurfaces, const GLvdpauSurfaceNV* surfaces)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLvdpauSurfaceNV*, void> glVDPAUMapSurfacesNV;

        /// <summary>GLvdpauSurfaceNV glVDPAURegisterOutputSurfaceNV(const void* vdpSurface, GLenum target, GLsizei numTextureNames, const GLuint* textureNames)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void*, GLenum, GLsizei, GLuint*, GLvdpauSurfaceNV> glVDPAURegisterOutputSurfaceNV;

        /// <summary>GLvdpauSurfaceNV glVDPAURegisterVideoSurfaceNV(const void* vdpSurface, GLenum target, GLsizei numTextureNames, const GLuint* textureNames)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void*, GLenum, GLsizei, GLuint*, GLvdpauSurfaceNV> glVDPAURegisterVideoSurfaceNV;

        /// <summary>void glVDPAUSurfaceAccessNV(GLvdpauSurfaceNV surface, GLenum access)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvdpauSurfaceNV, GLenum, void> glVDPAUSurfaceAccessNV;

        /// <summary>void glVDPAUUnmapSurfacesNV(GLsizei numSurface, const GLvdpauSurfaceNV* surfaces)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLvdpauSurfaceNV*, void> glVDPAUUnmapSurfacesNV;

        /// <summary>void glVDPAUUnregisterSurfaceNV(GLvdpauSurfaceNV surface)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvdpauSurfaceNV, void> glVDPAUUnregisterSurfaceNV;
    }
}
#endif