#if (GL_APPLE_specular_vector && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_LIGHT_MODEL_SPECULAR_VECTOR_APPLE = 0x85B0;
    }
}
#endif