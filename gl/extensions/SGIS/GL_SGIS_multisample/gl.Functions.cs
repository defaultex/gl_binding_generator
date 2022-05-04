#if (GL_SGIS_multisample && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSampleMaskSGIS(GLclampf value, GLboolean invert);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLclampf, GLboolean, void> glSampleMaskSGIS;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSamplePatternSGIS(GLenum pattern);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<SamplePatternSGIS, void> glSamplePatternSGIS;
#endif
    }
}
#endif