#if (GL_EXT_color_subtable && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glColorSubTableEXT(GLenum target, GLsizei start, GLsizei count, GLenum format, GLenum type, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorTableTarget, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glColorSubTableEXT;

        /// <summary>void glCopyColorSubTableEXT(GLenum target, GLsizei start, GLint x, GLint y, GLsizei width);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorTableTarget, GLsizei, GLint, GLint, GLsizei, void> glCopyColorSubTableEXT;
    }
}
#endif