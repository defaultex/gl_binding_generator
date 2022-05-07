#if (GL_QCOM_tiled_rendering && (!gles1 || !gles2))
public partial class gles1 { 
    public partial class Functions { 
        /// <summary>void glEndTilingQCOM(GLbitfield preserveMask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferBitQCOM, void> glEndTilingQCOM;

        /// <summary>void glStartTilingQCOM(GLuint x, GLuint y, GLuint width, GLuint height, GLbitfield preserveMask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, GLuint, BufferBitQCOM, void> glStartTilingQCOM;
    }
}
#endif