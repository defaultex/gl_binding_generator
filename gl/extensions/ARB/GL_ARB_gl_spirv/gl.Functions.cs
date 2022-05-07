#if (GL_ARB_gl_spirv && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glSpecializeShaderARB(GLuint shader, GLchar* pEntryPoint, GLuint numSpecializationConstants, GLuint* pConstantIndex, GLuint* pConstantValue);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshader, GLchar*, GLuint, GLuint*, GLuint*, void> glSpecializeShaderARB;
    }
}
#endif