#if (GL_QCOM_perfmon_global_mode && (GLES1_API || GLES2_API))
public partial class qcom { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PERFMON_GLOBAL_MODE_QCOM = 0x8FA0;
#endif
    }
}
#endif