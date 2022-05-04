#if (GL_NV_clip_space_w_scaling && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glViewportPositionWScaleNV(GLuint index, GLfloat xcoeff, GLfloat ycoeff);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, void> glViewportPositionWScaleNV;
#endif
    }
}
#endif