#if (GL_EXT_draw_buffers2 && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glColorMaskIndexedEXT(GLuint index, GLboolean r, GLboolean g, GLboolean b, GLboolean a);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean, GLboolean, GLboolean, GLboolean, void> glColorMaskIndexedEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDisableIndexedEXT(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glDisableIndexedEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEnableIndexedEXT(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glEnableIndexedEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetBooleanIndexedvEXT(GLenum target, GLuint index, GLboolean* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, GLboolean*, void> glGetBooleanIndexedvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetIntegerIndexedvEXT(GLenum target, GLuint index, GLint* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLint*, void> glGetIntegerIndexedvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsEnabledIndexedEXT(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, GLboolean> glIsEnabledIndexedEXT;
#endif
    }
}
#endif