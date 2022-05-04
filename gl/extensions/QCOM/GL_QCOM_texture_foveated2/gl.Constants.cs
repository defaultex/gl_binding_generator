#if (GL_QCOM_texture_foveated2 && GLES2_API)
public partial class qcom { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_FOVEATED_CUTOFF_DENSITY_QCOM = 0x96A0;
#endif
    }
}
#endif