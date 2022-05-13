#if GL_NV_draw_vulkan_image

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, GLsampler, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glDrawVkImageNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLchar*, GLVULKANPROCNV> glGetVkProcAddrNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, void> glSignalVkFenceNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, void> glSignalVkSemaphoreNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, void> glWaitVkSemaphoreNV;
    }
}

#endif