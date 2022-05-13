#if GL_NV_command_list

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glCallCommandListNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glCommandListSegmentsNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glCompileCommandListNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glCreateCommandListsNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glCreateStatesNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glDeleteCommandListsNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glDeleteStatesNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint64*, GLsizei*, GLuint, void> glDrawCommandsAddressNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLintptr*, GLsizei*, GLuint, void> glDrawCommandsNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64*, GLsizei*, GLuint*, GLuint*, GLuint, void> glDrawCommandsStatesAddressNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLintptr*, GLsizei*, GLuint*, GLuint*, GLuint, void> glDrawCommandsStatesNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLuint> glGetCommandHeaderNV;
        public static unsafe delegate* unmanaged[Cdecl]<ShaderType, GLushort> glGetStageIndexNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean> glIsCommandListNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean> glIsStateNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void**, GLsizei*, GLuint*, GLuint*, GLuint, void> glListDrawCommandsStatesClientNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLenum, void> glStateCaptureNV;
    }
}

#endif