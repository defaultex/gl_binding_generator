#if GL_ARB_geometry_shader4

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, GLtexture, GLint, void> glFramebufferTextureARB;
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, GLtexture, GLint, TextureTarget, void> glFramebufferTextureFaceARB;
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, GLtexture, GLint, GLint, void> glFramebufferTextureLayerARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramParameterParameter, GLint, void> glProgramParameteriARB;
    }
}

#endif