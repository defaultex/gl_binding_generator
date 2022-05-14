#if GL_MESA_framebuffer_flip_y

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferParameter, GLint, void> glFramebufferParameteriMESA;
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachmentParameter, GLint*, void> glGetFramebufferParameterivMESA;
    }
}

#endif