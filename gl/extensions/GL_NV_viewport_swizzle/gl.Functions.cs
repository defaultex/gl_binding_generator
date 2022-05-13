#if GL_NV_viewport_swizzle

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLenum, GLenum, GLenum, GLenum, void> glViewportSwizzleNV;
    }
}

#endif