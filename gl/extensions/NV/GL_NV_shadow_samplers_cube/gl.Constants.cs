#if (GL_NV_shadow_samplers_cube && GLES2_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLER_CUBE_SHADOW_NV = 0x8DC5;
#endif
    }
}
#endif