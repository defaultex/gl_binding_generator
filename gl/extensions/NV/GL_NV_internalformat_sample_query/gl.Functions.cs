#if (GL_NV_internalformat_sample_query && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetInternalformatSampleivNV(GLenum target, GLenum internalformat, GLsizei samples, GLenum pname, GLsizei count, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, InternalFormat, GLsizei, InternalFormatPName, GLsizei, GLint*, void> glGetInternalformatSampleivNV;
#endif
    }
}
#endif