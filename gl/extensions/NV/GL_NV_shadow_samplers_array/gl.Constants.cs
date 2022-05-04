#if (GL_NV_shadow_samplers_array && GLES2_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLER_2D_ARRAY_SHADOW_NV = 0x8DC4;
#endif
    }
}
#endif