#if (GL_3DFX_tbuffer && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glTbufferMask3DFX(GLuint mask)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glTbufferMask3DFX;
    }
}
#endif