#if (GL_QCOM_writeonly_rendering && (GLES1_API || GLES2_API))
public partial class qcom { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_WRITEONLY_RENDERING_QCOM = 0x8823;
#endif
    }
}
#endif