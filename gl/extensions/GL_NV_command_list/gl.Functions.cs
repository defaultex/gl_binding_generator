#if GL_NV_command_list

public partial class gl { 
    public partial class Functions { 

        /// <summary>void glCallCommandListNV(GLuint list);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glCallCommandListNV;

        /// <summary>void glCommandListSegmentsNV(GLuint list, GLuint segments);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glCommandListSegmentsNV;

        /// <summary>void glCompileCommandListNV(GLuint list);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glCompileCommandListNV;

        /// <summary>void glCreateCommandListsNV(GLsizei n, GLuint* lists);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glCreateCommandListsNV;

        /// <summary>void glCreateStatesNV(GLsizei n, GLuint* states);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glCreateStatesNV;

        /// <summary>void glDeleteCommandListsNV(GLsizei n, GLuint* lists);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glDeleteCommandListsNV;

        /// <summary>void glDeleteStatesNV(GLsizei n, GLuint* states);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glDeleteStatesNV;

        /// <summary>void glDrawCommandsAddressNV(GLenum primitiveMode, GLuint64* indirects, GLsizei* sizes, GLuint count);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint64*, GLsizei*, GLuint, void> glDrawCommandsAddressNV;

        /// <summary>void glDrawCommandsNV(GLenum primitiveMode, GLuint buffer, GLintptr* indirects, GLsizei* sizes, GLuint count);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLintptr*, GLsizei*, GLuint, void> glDrawCommandsNV;

        /// <summary>void glDrawCommandsStatesAddressNV(GLuint64* indirects, GLsizei* sizes, GLuint* states, GLuint* fbos, GLuint count);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64*, GLsizei*, GLuint*, GLuint*, GLuint, void> glDrawCommandsStatesAddressNV;

        /// <summary>void glDrawCommandsStatesNV(GLuint buffer, GLintptr* indirects, GLsizei* sizes, GLuint* states, GLuint* fbos, GLuint count);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLintptr*, GLsizei*, GLuint*, GLuint*, GLuint, void> glDrawCommandsStatesNV;

        /// <summary>GLuint glGetCommandHeaderNV(GLenum tokenID, GLuint size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLuint> glGetCommandHeaderNV;

        /// <summary>GLushort glGetStageIndexNV(GLenum shadertype);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShaderType, GLushort> glGetStageIndexNV;

        /// <summary>GLboolean glIsCommandListNV(GLuint list);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean> glIsCommandListNV;

        /// <summary>GLboolean glIsStateNV(GLuint state);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean> glIsStateNV;

        /// <summary>void glListDrawCommandsStatesClientNV(GLuint list, GLuint segment, void** indirects, GLsizei* sizes, GLuint* states, GLuint* fbos, GLuint count);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void**, GLsizei*, GLuint*, GLuint*, GLuint, void> glListDrawCommandsStatesClientNV;

        /// <summary>void glStateCaptureNV(GLuint state, GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLenum, void> glStateCaptureNV;
    }
}

#endif