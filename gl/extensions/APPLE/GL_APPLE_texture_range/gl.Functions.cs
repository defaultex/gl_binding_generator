#if (GL_APPLE_texture_range && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetTexParameterPointervAPPLE(GLenum target, GLenum pname, void** params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLenum, void**, void> glGetTexParameterPointervAPPLE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureRangeAPPLE(GLenum target, GLsizei length, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLsizei, void*, void> glTextureRangeAPPLE;
#endif
    }
}
#endif