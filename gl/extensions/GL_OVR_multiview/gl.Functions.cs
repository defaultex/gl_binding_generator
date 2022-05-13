#if GL_OVR_multiview

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, GLtexture, GLint, GLint, GLsizei, void> glFramebufferTextureMultiviewOVR;
    }
}

#endif