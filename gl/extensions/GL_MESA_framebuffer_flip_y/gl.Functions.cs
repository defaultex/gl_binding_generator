#if GL_MESA_framebuffer_flip_y

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferParameterName, GLint, void> glFramebufferParameteriMESA;
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachmentParameterName, GLint*, void> glGetFramebufferParameterivMESA;
    }
}

#endif