#if (GL_NV_viewport_swizzle && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glViewportSwizzleNV(GLuint index, GLenum swizzlex, GLenum swizzley, GLenum swizzlez, GLenum swizzlew)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLenum, GLenum, GLenum, GLenum, void> glViewportSwizzleNV;
    }
}
#endif