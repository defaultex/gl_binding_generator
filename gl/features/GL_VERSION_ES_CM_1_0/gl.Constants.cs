#if (GL_VERSION_ES_CM_1_0 && GLES1_API)
public partial class gles1 { 
    public partial class Constants { 

#if !GL_SC_VERSION_2_0
        public const GLenum GL_VERSION_ES_CL_1_0 = 1;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_VERSION_ES_CM_1_1 = 1;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_VERSION_ES_CL_1_1 = 1;
#endif
    }
}
#endif