#if (GL_ARB_gl_spirv && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSpecializeShaderARB(GLuint shader, GLchar* pEntryPoint, GLuint numSpecializationConstants, GLuint* pConstantIndex, GLuint* pConstantValue);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<shader, GLchar*, GLuint, GLuint*, GLuint*, void> glSpecializeShaderARB;
#endif
    }
}
#endif