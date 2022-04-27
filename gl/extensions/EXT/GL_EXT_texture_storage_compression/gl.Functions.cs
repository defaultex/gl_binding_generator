#if (GL_EXT_texture_storage_compression && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glTexStorageAttribs2DEXT(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, const GLint*  attrib_list)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, TexStorageAttribs*, void> glTexStorageAttribs2DEXT;

        /// <summary>void glTexStorageAttribs3DEXT(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, const GLint*  attrib_list)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLsizei, TexStorageAttribs*, void> glTexStorageAttribs3DEXT;
    }
}
#endif