#if GL_NV_internalformat_sample_query

public partial class gl { 
    public partial class Functions { 

        /// <summary>void glGetInternalformatSampleivNV(GLenum target, GLenum internalformat, GLsizei samples, GLenum pname, GLsizei count, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, InternalFormat, GLsizei, InternalFormatParameter, GLsizei, GLint*, void> glGetInternalformatSampleivNV;
    }
}

#endif