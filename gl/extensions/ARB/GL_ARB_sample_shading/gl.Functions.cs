#if (GL_ARB_sample_shading && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMinSampleShadingARB(GLfloat value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glMinSampleShadingARB;
#endif
    }
}
#endif