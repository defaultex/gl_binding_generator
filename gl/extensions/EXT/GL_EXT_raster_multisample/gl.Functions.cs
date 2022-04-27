#if (GL_EXT_raster_multisample && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glRasterSamplesEXT(GLuint samples, GLboolean fixedsamplelocations)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean, void> glRasterSamplesEXT;
    }
}
#endif