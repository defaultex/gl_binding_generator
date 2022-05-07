#if (GL_ARB_internalformat_query && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glGetInternalformativ(GLenum target, GLenum internalformat, GLenum pname, GLsizei count, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, InternalFormat, InternalFormatPName, GLsizei, GLint*, void> glGetInternalformativ;
    }
}
#endif