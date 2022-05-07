#if (GL_EXT_multisample && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glSampleMaskEXT(GLclampf value, GLboolean invert);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLclampf, GLboolean, void> glSampleMaskEXT;

        /// <summary>void glSamplePatternEXT(GLenum pattern);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<SamplePatternEXT, void> glSamplePatternEXT;
    }
}
#endif