#if (GL_ARB_internalformat_query2 && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glGetInternalformati64v(GLenum target, GLenum internalformat, GLenum pname, GLsizei count, GLint64* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, InternalFormat, InternalFormatPName, GLsizei, GLint64*, void> glGetInternalformati64v;
    }
}
#endif