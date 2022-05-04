#if (GL_NV_register_combiners2 && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PER_STAGE_CONSTANTS_NV = 0x8535;
#endif
    }
}
#endif