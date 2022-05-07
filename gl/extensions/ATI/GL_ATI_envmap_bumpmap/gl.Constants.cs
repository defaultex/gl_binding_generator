#if (GL_ATI_envmap_bumpmap && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_BUMP_ROT_MATRIX_ATI = 0x8775;
        public const GLenum GL_BUMP_ROT_MATRIX_SIZE_ATI = 0x8776;
        public const GLenum GL_BUMP_NUM_TEX_UNITS_ATI = 0x8777;
        public const GLenum GL_BUMP_TEX_UNITS_ATI = 0x8778;
        public const GLenum GL_DUDV_ATI = 0x8779;
        public const GLenum GL_DU8DV8_ATI = 0x877A;
        public const GLenum GL_BUMP_ENVMAP_ATI = 0x877B;
        public const GLenum GL_BUMP_TARGET_ATI = 0x877C;
    }
}
#endif