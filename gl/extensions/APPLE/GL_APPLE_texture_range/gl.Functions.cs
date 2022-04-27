#if (GL_APPLE_texture_range && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glGetTexParameterPointervAPPLE(GLenum target, GLenum pname, void** params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLenum, void**, void> glGetTexParameterPointervAPPLE;

        /// <summary>void glTextureRangeAPPLE(GLenum target, GLsizei length, const void* pointer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLsizei, void*, void> glTextureRangeAPPLE;
    }
}
#endif