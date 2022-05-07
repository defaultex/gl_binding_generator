#if (GL_ARB_spirv_extensions && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_SPIR_V_EXTENSIONS = 0x9553;
        public const GLenum GL_NUM_SPIR_V_EXTENSIONS = 0x9554;
    }
}
#endif