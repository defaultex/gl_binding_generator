#if GL_EXT_raster_multisample

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean, void> glRasterSamplesEXT;
    }
}

#endif