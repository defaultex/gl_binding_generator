#if (GL_ATI_envmap_bumpmap && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetTexBumpParameterfvATI(GLenum pname, GLfloat* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetTexBumpParameterATI, GLfloat*, void> glGetTexBumpParameterfvATI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetTexBumpParameterivATI(GLenum pname, GLint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetTexBumpParameterATI, GLint*, void> glGetTexBumpParameterivATI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexBumpParameterfvATI(GLenum pname, GLfloat* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexBumpParameterATI, GLfloat*, void> glTexBumpParameterfvATI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexBumpParameterivATI(GLenum pname, GLint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexBumpParameterATI, GLint*, void> glTexBumpParameterivATI;
#endif
    }
}
#endif