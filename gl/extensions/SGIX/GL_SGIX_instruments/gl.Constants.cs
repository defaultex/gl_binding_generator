#if (GL_SGIX_instruments && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_INSTRUMENT_BUFFER_POINTER_SGIX = 0x8180;
        public const GLenum GL_INSTRUMENT_MEASUREMENTS_SGIX = 0x8181;
    }
}
#endif