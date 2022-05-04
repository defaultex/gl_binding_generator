#if (GL_OES_mapbuffer && (GLES1_API || GLES2_API))
public partial class gles1 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetBufferPointervOES(GLenum target, GLenum pname, void** params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, BufferPointerNameARB, void**, void> glGetBufferPointervOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void* glMapBufferOES(GLenum target, GLenum access);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, BufferAccessARB, void*> glMapBufferOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glUnmapBufferOES(GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLboolean> glUnmapBufferOES;
#endif
    }
}
#endif