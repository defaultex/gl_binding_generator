#if (GL_EXT_bindable_uniform && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>GLint glGetUniformBufferSizeEXT(GLuint program, GLint location);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLint> glGetUniformBufferSizeEXT;

        /// <summary>GLintptr glGetUniformOffsetEXT(GLuint program, GLint location);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLintptr> glGetUniformOffsetEXT;

        /// <summary>void glUniformBufferEXT(GLuint program, GLint location, GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLbuffer, void> glUniformBufferEXT;
    }
}
#endif