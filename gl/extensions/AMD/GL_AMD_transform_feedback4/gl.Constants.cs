#if (GL_AMD_transform_feedback4 && GL_API)
public partial class amd { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_STREAM_RASTERIZATION_AMD = 0x91A0;
#endif
    }
}
#endif