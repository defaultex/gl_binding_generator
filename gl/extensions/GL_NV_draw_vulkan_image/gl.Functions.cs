#if GL_NV_draw_vulkan_image

public partial class gl { 
    public partial class Functions { 

        /// <summary>void glDrawVkImageNV(GLuint64 vkImage, GLuint sampler, GLfloat x0, GLfloat y0, GLfloat x1, GLfloat y1, GLfloat z, GLfloat s0, GLfloat t0, GLfloat s1, GLfloat t1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, GLsampler, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glDrawVkImageNV;

        /// <summary>GLVULKANPROCNV glGetVkProcAddrNV(GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLchar*, GLVULKANPROCNV> glGetVkProcAddrNV;

        /// <summary>void glSignalVkFenceNV(GLuint64 vkFence);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, void> glSignalVkFenceNV;

        /// <summary>void glSignalVkSemaphoreNV(GLuint64 vkSemaphore);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, void> glSignalVkSemaphoreNV;

        /// <summary>void glWaitVkSemaphoreNV(GLuint64 vkSemaphore);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, void> glWaitVkSemaphoreNV;
    }
}

#endif