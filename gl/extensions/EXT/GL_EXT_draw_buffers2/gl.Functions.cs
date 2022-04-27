#if (GL_EXT_draw_buffers2 && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glColorMaskIndexedEXT(GLuint index, GLboolean r, GLboolean g, GLboolean b, GLboolean a)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean, GLboolean, GLboolean, GLboolean, void> glColorMaskIndexedEXT;

        /// <summary>void glDisableIndexedEXT(GLenum target, GLuint index)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glDisableIndexedEXT;

        /// <summary>void glEnableIndexedEXT(GLenum target, GLuint index)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glEnableIndexedEXT;

        /// <summary>void glGetBooleanIndexedvEXT(GLenum target, GLuint index, GLboolean* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, GLboolean*, void> glGetBooleanIndexedvEXT;

        /// <summary>void glGetIntegerIndexedvEXT(GLenum target, GLuint index, GLint* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLint*, void> glGetIntegerIndexedvEXT;

        /// <summary>GLboolean glIsEnabledIndexedEXT(GLenum target, GLuint index)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, GLboolean> glIsEnabledIndexedEXT;
    }
}
#endif