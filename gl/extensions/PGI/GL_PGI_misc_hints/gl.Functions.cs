#if (GL_PGI_misc_hints && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glHintPGI(GLenum target, GLint mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<HintTargetPGI, GLint, void> glHintPGI;
    }
}
#endif