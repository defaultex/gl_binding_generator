#if (GL_NV_blend_equation_advanced_coherent && (GL_API || GLCORE_API || GLES2_API))
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BLEND_ADVANCED_COHERENT_NV = 0x9285;
#endif
    }
}
#endif