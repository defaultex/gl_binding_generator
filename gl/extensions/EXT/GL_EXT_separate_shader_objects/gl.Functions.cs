#if (GL_EXT_separate_shader_objects && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glActiveProgramEXT(GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, void> glActiveProgramEXT;

        /// <summary>void glActiveShaderProgramEXT(GLuint pipeline, GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogrampipeline, GLprogram, void> glActiveShaderProgramEXT;

        /// <summary>void glBindProgramPipelineEXT(GLuint pipeline);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogrampipeline, void> glBindProgramPipelineEXT;

        /// <summary>GLuint glCreateShaderProgramEXT(GLenum type, GLchar* string);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShaderType, GLchar*, GLprogram> glCreateShaderProgramEXT;

        /// <summary>GLuint glCreateShaderProgramvEXT(GLenum type, GLsizei count, GLchar** strings);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShaderType, GLsizei, GLchar**, GLprogram> glCreateShaderProgramvEXT;

        /// <summary>void glDeleteProgramPipelinesEXT(GLsizei n, GLuint* pipelines);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLprogrampipeline*, void> glDeleteProgramPipelinesEXT;

        /// <summary>void glGenProgramPipelinesEXT(GLsizei n, GLuint* pipelines);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLprogrampipeline*, void> glGenProgramPipelinesEXT;

        /// <summary>void glGetProgramPipelineInfoLogEXT(GLuint pipeline, GLsizei bufSize, GLsizei* length, GLchar* infoLog);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogrampipeline, GLsizei, GLsizei*, GLchar*, void> glGetProgramPipelineInfoLogEXT;

        /// <summary>void glGetProgramPipelineivEXT(GLuint pipeline, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogrampipeline, PipelineParameterName, GLint*, void> glGetProgramPipelineivEXT;

        /// <summary>GLboolean glIsProgramPipelineEXT(GLuint pipeline);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogrampipeline, GLboolean> glIsProgramPipelineEXT;

        /// <summary>void glUseProgramStagesEXT(GLuint pipeline, GLbitfield stages, GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogrampipeline, UseProgramStageMask, GLprogram, void> glUseProgramStagesEXT;

        /// <summary>void glUseShaderProgramEXT(GLenum type, GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLprogram, void> glUseShaderProgramEXT;

        /// <summary>void glValidateProgramPipelineEXT(GLuint pipeline);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogrampipeline, void> glValidateProgramPipelineEXT;
    }
}
#endif