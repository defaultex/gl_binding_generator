#if (GL_EXT_shader_image_load_store && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBindImageTextureEXT(GLuint index, GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum access, GLint format);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLtexture, GLint, GLboolean, GLint, BufferAccessARB, GLint, void> glBindImageTextureEXT;

        /// <summary>void glMemoryBarrierEXT(GLbitfield barriers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MemoryBarrierMask, void> glMemoryBarrierEXT;
    }
}
#endif