#if (GL_3DFX_tbuffer && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTbufferMask3DFX(GLuint mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glTbufferMask3DFX;
#endif
    }
}
#endif