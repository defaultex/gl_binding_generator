#if (GL_NV_primitive_restart && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_PRIMITIVE_RESTART_NV = 0x8558;
        public const GLenum GL_PRIMITIVE_RESTART_INDEX_NV = 0x8559;
    }
}
#endif