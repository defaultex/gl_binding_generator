#if (GL_NV_draw_vulkan_image && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glDrawVkImageNV(GLuint64 vkImage, GLuint sampler, GLfloat x0, GLfloat y0, GLfloat x1, GLfloat y1, GLfloat z, GLfloat s0, GLfloat t0, GLfloat s1, GLfloat t1)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, GLsampler, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glDrawVkImageNV;

        /// <summary>GLVULKANPROCNV glGetVkProcAddrNV(const GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLchar*, GLVULKANPROCNV> glGetVkProcAddrNV;

        /// <summary>void glWaitVkSemaphoreNV(GLuint64 vkSemaphore)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, void> glWaitVkSemaphoreNV;

        /// <summary>void glSignalVkSemaphoreNV(GLuint64 vkSemaphore)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, void> glSignalVkSemaphoreNV;

        /// <summary>void glSignalVkFenceNV(GLuint64 vkFence)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, void> glSignalVkFenceNV;
    }
}
#endif