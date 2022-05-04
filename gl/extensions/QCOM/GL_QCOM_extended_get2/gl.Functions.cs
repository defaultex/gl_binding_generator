#if (GL_QCOM_extended_get2 && (GLES1_API || GLES2_API))
public partial class gles1 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glExtGetProgramBinarySourceQCOM(GLuint program, GLenum shadertype, GLchar* source, GLint* length);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ShaderType, GLchar*, GLint*, void> glExtGetProgramBinarySourceQCOM;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glExtGetProgramsQCOM(GLuint* programs, GLint maxPrograms, GLint* numPrograms);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program*, GLint, GLint*, void> glExtGetProgramsQCOM;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glExtGetShadersQCOM(GLuint* shaders, GLint maxShaders, GLint* numShaders);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<shader*, GLint, GLint*, void> glExtGetShadersQCOM;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glExtIsProgramBinaryQCOM(GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLboolean> glExtIsProgramBinaryQCOM;
#endif
    }
}
#endif