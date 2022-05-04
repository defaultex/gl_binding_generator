#if (GL_QCOM_frame_extrapolation && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glExtrapolateTex2DQCOM(GLuint src1, GLuint src2, GLuint output, GLfloat scaleFactor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, texture, texture, GLfloat, void> glExtrapolateTex2DQCOM;
#endif
    }
}
#endif