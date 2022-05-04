#if (GL_ARB_shader_storage_buffer_object && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glShaderStorageBlockBinding(GLuint program, GLuint storageBlockIndex, GLuint storageBlockBinding);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLuint, GLuint, void> glShaderStorageBlockBinding;
#endif
    }
}
#endif