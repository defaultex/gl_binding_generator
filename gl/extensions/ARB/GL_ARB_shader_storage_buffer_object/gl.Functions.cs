#if (GL_ARB_shader_storage_buffer_object && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glShaderStorageBlockBinding(GLuint program, GLuint storageBlockIndex, GLuint storageBlockBinding);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLuint, void> glShaderStorageBlockBinding;
    }
}
#endif