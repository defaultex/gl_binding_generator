#if (GL_PGI_misc_hints && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glHintPGI(GLenum target, GLint mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<HintTargetPGI, GLint, void> glHintPGI;
#endif
    }
}
#endif