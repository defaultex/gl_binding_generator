#if (GL_NV_vdpau_interop2 && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>GLvdpauSurfaceNV glVDPAURegisterVideoSurfaceWithPictureStructureNV(const void* vdpSurface, GLenum target, GLsizei numTextureNames, const GLuint* textureNames, GLboolean isFrameStructure)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void*, GLenum, GLsizei, GLuint*, GLboolean, GLvdpauSurfaceNV> glVDPAURegisterVideoSurfaceWithPictureStructureNV;
    }
}
#endif