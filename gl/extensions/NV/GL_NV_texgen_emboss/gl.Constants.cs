#if (GL_NV_texgen_emboss && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_EMBOSS_LIGHT_NV = 0x855D;
        public const GLenum GL_EMBOSS_CONSTANT_NV = 0x855E;
        public const GLenum GL_EMBOSS_MAP_NV = 0x855F;
    }
}
#endif