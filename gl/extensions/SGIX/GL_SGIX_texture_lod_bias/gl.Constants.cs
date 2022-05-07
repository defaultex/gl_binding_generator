#if (GL_SGIX_texture_lod_bias && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_LOD_BIAS_S_SGIX = 0x818E;
        public const GLenum GL_TEXTURE_LOD_BIAS_T_SGIX = 0x818F;
        public const GLenum GL_TEXTURE_LOD_BIAS_R_SGIX = 0x8190;
    }
}
#endif