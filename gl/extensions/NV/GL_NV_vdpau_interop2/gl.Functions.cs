#if (GL_NV_vdpau_interop2 && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>GLvdpauSurfaceNV glVDPAURegisterVideoSurfaceWithPictureStructureNV(void* vdpSurface, GLenum target, GLsizei numTextureNames, GLuint* textureNames, GLboolean isFrameStructure);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void*, GLenum, GLsizei, GLuint*, GLboolean, GLvdpauSurfaceNV> glVDPAURegisterVideoSurfaceWithPictureStructureNV;
    }
}
#endif