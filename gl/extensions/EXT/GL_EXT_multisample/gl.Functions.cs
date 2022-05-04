#if (GL_EXT_multisample && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSampleMaskEXT(GLclampf value, GLboolean invert);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLclampf, GLboolean, void> glSampleMaskEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSamplePatternEXT(GLenum pattern);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<SamplePatternEXT, void> glSamplePatternEXT;
#endif
    }
}
#endif