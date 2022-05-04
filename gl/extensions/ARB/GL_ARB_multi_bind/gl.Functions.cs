#if (GL_ARB_multi_bind && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glBindBuffersBase(GLenum target, GLuint first, GLsizei count, GLuint* buffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, GLsizei, buffer*, void> glBindBuffersBase;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glBindBuffersRange(GLenum target, GLuint first, GLsizei count, GLuint* buffers, GLintptr* offsets, GLsizeiptr* sizes);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, GLsizei, buffer*, GLintptr*, GLsizeiptr*, void> glBindBuffersRange;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glBindImageTextures(GLuint first, GLsizei count, GLuint* textures);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, texture*, void> glBindImageTextures;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glBindSamplers(GLuint first, GLsizei count, GLuint* samplers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, sampler*, void> glBindSamplers;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glBindTextures(GLuint first, GLsizei count, GLuint* textures);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, texture*, void> glBindTextures;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glBindVertexBuffers(GLuint first, GLsizei count, GLuint* buffers, GLintptr* offsets, GLsizei* strides);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, buffer*, GLintptr*, GLsizei*, void> glBindVertexBuffers;
#endif
    }
}
#endif