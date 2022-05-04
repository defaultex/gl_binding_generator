#if (GL_EXT_shader_image_load_store && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBindImageTextureEXT(GLuint index, GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum access, GLint format);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, texture, GLint, GLboolean, GLint, BufferAccessARB, GLint, void> glBindImageTextureEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMemoryBarrierEXT(GLbitfield barriers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MemoryBarrierMask, void> glMemoryBarrierEXT;
#endif
    }
}
#endif