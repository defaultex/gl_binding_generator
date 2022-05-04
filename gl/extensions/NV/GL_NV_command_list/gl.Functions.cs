#if (GL_NV_command_list && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCallCommandListNV(GLuint list);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glCallCommandListNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCommandListSegmentsNV(GLuint list, GLuint segments);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glCommandListSegmentsNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCompileCommandListNV(GLuint list);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glCompileCommandListNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCreateCommandListsNV(GLsizei n, GLuint* lists);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glCreateCommandListsNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCreateStatesNV(GLsizei n, GLuint* states);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glCreateStatesNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDeleteCommandListsNV(GLsizei n, GLuint* lists);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glDeleteCommandListsNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDeleteStatesNV(GLsizei n, GLuint* states);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glDeleteStatesNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDrawCommandsAddressNV(GLenum primitiveMode, GLuint64* indirects, GLsizei* sizes, GLuint count);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint64*, GLsizei*, GLuint, void> glDrawCommandsAddressNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDrawCommandsNV(GLenum primitiveMode, GLuint buffer, GLintptr* indirects, GLsizei* sizes, GLuint count);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLintptr*, GLsizei*, GLuint, void> glDrawCommandsNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDrawCommandsStatesAddressNV(GLuint64* indirects, GLsizei* sizes, GLuint* states, GLuint* fbos, GLuint count);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64*, GLsizei*, GLuint*, GLuint*, GLuint, void> glDrawCommandsStatesAddressNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDrawCommandsStatesNV(GLuint buffer, GLintptr* indirects, GLsizei* sizes, GLuint* states, GLuint* fbos, GLuint count);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, GLintptr*, GLsizei*, GLuint*, GLuint*, GLuint, void> glDrawCommandsStatesNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLuint glGetCommandHeaderNV(GLenum tokenID, GLuint size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLuint> glGetCommandHeaderNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLushort glGetStageIndexNV(GLenum shadertype);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShaderType, GLushort> glGetStageIndexNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsCommandListNV(GLuint list);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean> glIsCommandListNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsStateNV(GLuint state);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean> glIsStateNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glListDrawCommandsStatesClientNV(GLuint list, GLuint segment, void** indirects, GLsizei* sizes, GLuint* states, GLuint* fbos, GLuint count);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void**, GLsizei*, GLuint*, GLuint*, GLuint, void> glListDrawCommandsStatesClientNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glStateCaptureNV(GLuint state, GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLenum, void> glStateCaptureNV;
#endif
    }
}
#endif