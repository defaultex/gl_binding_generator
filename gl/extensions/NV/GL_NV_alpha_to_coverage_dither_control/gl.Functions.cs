#if (GL_NV_alpha_to_coverage_dither_control && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glAlphaToCoverageDitherControlNV(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, void> glAlphaToCoverageDitherControlNV;
#endif
    }
}
#endif