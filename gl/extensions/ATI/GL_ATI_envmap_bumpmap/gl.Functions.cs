#if (GL_ATI_envmap_bumpmap && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glGetTexBumpParameterfvATI(GLenum pname, GLfloat* param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetTexBumpParameterATI, GLfloat*, void> glGetTexBumpParameterfvATI;

        /// <summary>void glGetTexBumpParameterivATI(GLenum pname, GLint* param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetTexBumpParameterATI, GLint*, void> glGetTexBumpParameterivATI;

        /// <summary>void glTexBumpParameterfvATI(GLenum pname, const GLfloat* param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexBumpParameterATI, GLfloat*, void> glTexBumpParameterfvATI;

        /// <summary>void glTexBumpParameterivATI(GLenum pname, const GLint* param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexBumpParameterATI, GLint*, void> glTexBumpParameterivATI;
    }
}
#endif