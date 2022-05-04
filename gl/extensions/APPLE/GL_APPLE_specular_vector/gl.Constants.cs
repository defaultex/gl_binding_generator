#if (GL_APPLE_specular_vector && GL_API)
public partial class apple { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LIGHT_MODEL_SPECULAR_VECTOR_APPLE = 0x85B0;
#endif
    }
}
#endif