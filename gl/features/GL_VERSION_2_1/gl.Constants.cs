#if (GL_VERSION_2_1 && GL_API)
public partial class gl { 
    public partial class Constants { 

#if !GL_SC_VERSION_2_0
        public const GLenum GL_CURRENT_RASTER_SECONDARY_COLOR = 0x845F;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_PIXEL_PACK_BUFFER = 0x88EB;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_PIXEL_UNPACK_BUFFER = 0x88EC;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_PIXEL_PACK_BUFFER_BINDING = 0x88ED;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_PIXEL_UNPACK_BUFFER_BINDING = 0x88EF;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_FLOAT_MAT2x3 = 0x8B65;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_FLOAT_MAT2x4 = 0x8B66;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_FLOAT_MAT3x2 = 0x8B67;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_FLOAT_MAT3x4 = 0x8B68;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_FLOAT_MAT4x2 = 0x8B69;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_FLOAT_MAT4x3 = 0x8B6A;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_SRGB = 0x8C40;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_SRGB8 = 0x8C41;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_SRGB_ALPHA = 0x8C42;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_SRGB8_ALPHA8 = 0x8C43;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_SLUMINANCE_ALPHA = 0x8C44;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_SLUMINANCE8_ALPHA8 = 0x8C45;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_SLUMINANCE = 0x8C46;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_SLUMINANCE8 = 0x8C47;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_COMPRESSED_SRGB = 0x8C48;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_COMPRESSED_SRGB_ALPHA = 0x8C49;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_COMPRESSED_SLUMINANCE = 0x8C4A;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_COMPRESSED_SLUMINANCE_ALPHA = 0x8C4B;
#endif
    }
}
#endif