#if (GL_INTEL_conservative_rasterization && (GL_API || GLCORE_API || GLES2_API))
public partial class intel { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONSERVATIVE_RASTERIZATION_INTEL = 0x83FE;
#endif
    }
}
#endif