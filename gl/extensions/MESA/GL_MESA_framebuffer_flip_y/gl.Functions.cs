#if (GL_MESA_framebuffer_flip_y && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glFramebufferParameteriMESA(GLenum target, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferParameterName, GLint, void> glFramebufferParameteriMESA;

        /// <summary>void glGetFramebufferParameterivMESA(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachmentParameterName, GLint*, void> glGetFramebufferParameterivMESA;
    }
}
#endif