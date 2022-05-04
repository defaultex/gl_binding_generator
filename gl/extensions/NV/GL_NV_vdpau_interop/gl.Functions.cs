#if (GL_NV_vdpau_interop && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVDPAUFiniNV();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glVDPAUFiniNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVDPAUGetSurfaceivNV(GLvdpauSurfaceNV surface, GLenum pname, GLsizei count, GLsizei* length, GLint* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvdpauSurfaceNV, GLenum, GLsizei, GLsizei*, GLint*, void> glVDPAUGetSurfaceivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVDPAUInitNV(void* vdpDevice, void* getProcAddress);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void*, void*, void> glVDPAUInitNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glVDPAUIsSurfaceNV(GLvdpauSurfaceNV surface);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvdpauSurfaceNV, GLboolean> glVDPAUIsSurfaceNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVDPAUMapSurfacesNV(GLsizei numSurfaces, GLvdpauSurfaceNV* surfaces);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLvdpauSurfaceNV*, void> glVDPAUMapSurfacesNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLvdpauSurfaceNV glVDPAURegisterOutputSurfaceNV(void* vdpSurface, GLenum target, GLsizei numTextureNames, GLuint* textureNames);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void*, GLenum, GLsizei, GLuint*, GLvdpauSurfaceNV> glVDPAURegisterOutputSurfaceNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLvdpauSurfaceNV glVDPAURegisterVideoSurfaceNV(void* vdpSurface, GLenum target, GLsizei numTextureNames, GLuint* textureNames);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void*, GLenum, GLsizei, GLuint*, GLvdpauSurfaceNV> glVDPAURegisterVideoSurfaceNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVDPAUSurfaceAccessNV(GLvdpauSurfaceNV surface, GLenum access);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvdpauSurfaceNV, GLenum, void> glVDPAUSurfaceAccessNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVDPAUUnmapSurfacesNV(GLsizei numSurface, GLvdpauSurfaceNV* surfaces);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLvdpauSurfaceNV*, void> glVDPAUUnmapSurfacesNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVDPAUUnregisterSurfaceNV(GLvdpauSurfaceNV surface);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvdpauSurfaceNV, void> glVDPAUUnregisterSurfaceNV;
#endif
    }
}
#endif