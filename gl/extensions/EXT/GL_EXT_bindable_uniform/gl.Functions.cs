#if (GL_EXT_bindable_uniform && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLint glGetUniformBufferSizeEXT(GLuint program, GLint location);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLint> glGetUniformBufferSizeEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLintptr glGetUniformOffsetEXT(GLuint program, GLint location);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLintptr> glGetUniformOffsetEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniformBufferEXT(GLuint program, GLint location, GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, buffer, void> glUniformBufferEXT;
#endif
    }
}
#endif