#if (GL_NV_half_float && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_HALF_FLOAT_NV = 0x140B;
#endif
    }
}
#endif