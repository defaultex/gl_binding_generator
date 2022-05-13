#if GL_NV_internalformat_sample_query

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, InternalFormat, GLsizei, InternalFormatPName, GLsizei, GLint*, void> glGetInternalformatSampleivNV;
    }
}

#endif