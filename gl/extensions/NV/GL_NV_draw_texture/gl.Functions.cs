#if (GL_NV_draw_texture && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glDrawTextureNV(GLuint texture, GLuint sampler, GLfloat x0, GLfloat y0, GLfloat x1, GLfloat y1, GLfloat z, GLfloat s0, GLfloat t0, GLfloat s1, GLfloat t1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLsampler, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glDrawTextureNV;
    }
}
#endif