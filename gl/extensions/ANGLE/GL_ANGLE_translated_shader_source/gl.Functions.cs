#if (GL_ANGLE_translated_shader_source && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetTranslatedShaderSourceANGLE(GLuint shader, GLsizei bufSize, GLsizei* length, GLchar* source);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<shader, GLsizei, GLsizei*, GLchar*, void> glGetTranslatedShaderSourceANGLE;
#endif
    }
}
#endif