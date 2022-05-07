#if (GL_NV_texgen_reflection && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_NORMAL_MAP_NV = 0x8511;
        public const GLenum GL_REFLECTION_MAP_NV = 0x8512;
    }
}
#endif